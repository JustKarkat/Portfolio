#include "CHIP_8.h"
#include <stdio.h>
#include <iostream>
#include <bitset>
#include <ctime>
#include <SFML/Audio.hpp>

unsigned char chip8_fontset[80] =
{
  0xF0, 0x90, 0x90, 0x90, 0xF0, // 0
  0x20, 0x60, 0x20, 0x20, 0x70, // 1
  0xF0, 0x10, 0xF0, 0x80, 0xF0, // 2
  0xF0, 0x10, 0xF0, 0x10, 0xF0, // 3
  0x90, 0x90, 0xF0, 0x10, 0x10, // 4
  0xF0, 0x80, 0xF0, 0x10, 0xF0, // 5
  0xF0, 0x80, 0xF0, 0x90, 0xF0, // 6
  0xF0, 0x10, 0x20, 0x40, 0x40, // 7
  0xF0, 0x90, 0xF0, 0x90, 0xF0, // 8
  0xF0, 0x90, 0xF0, 0x10, 0xF0, // 9
  0xF0, 0x90, 0xF0, 0x90, 0x90, // A
  0xE0, 0x90, 0xE0, 0x90, 0xE0, // B
  0xF0, 0x80, 0x80, 0x80, 0xF0, // C
  0xE0, 0x90, 0x90, 0x90, 0xE0, // D
  0xF0, 0x80, 0xF0, 0x80, 0xF0, // E
  0xF0, 0x80, 0xF0, 0x80, 0x80  // F
};

sf::SoundBuffer beep;
sf::Sound beepsound;


CHIP_8::CHIP_8()
{
}


CHIP_8::~CHIP_8()
{
}

void CHIP_8::initialize()
{
	if (!beep.loadFromFile("beep.wav"))
	{
		return;
	}
	beepsound.setBuffer(beep);
	p_count = 0x200;
	cur_opcode = 0;
	I = 0;
	stck_ptr = 0;

	for (int i = 0; i < 4096; ++i) // CLEARS Memory
	{
		memory[i] = 0;
	}

	cleardisplay();

	for (int i = 0; i < 16; ++i) //CLEARS STACK
	{
		stack[i] = 0;
	}

	for (int i = 0; i < 16; ++i) // CLEARS Registers
	{
		V[i] = 0;
	}

	for (int i = 0; i < 80; ++i)
	{
		memory[i] = chip8_fontset[i];
	}
	for (int i = 0; i < 16; ++i)
	{
		key[i] = 0;
	}

	delaytmr = 0;
	soundtmr = 0;
	

}

void CHIP_8::loadGame(char g[64])
{
	const int buffsize = 4096;
	unsigned char buffer[buffsize];
	FILE * file;
	fopen_s(&file, g, "rb");
	if (!file)
	{
		std::cout << "Failed to get file.";
		return;
	}

	int bytes_read = fread(buffer, sizeof(char), buffsize, file);

	for (int i = 0; i < 4096; ++i)
	{
		if (!(i > ftell(file) - 1))
			memory[i + 512] = buffer[i];
	}



}

void CHIP_8::emulateCycle()
{

	//Gets Opcode
	cur_opcode = memory[p_count] << 8 | memory[p_count + 1];

	//Decode Opcode

	std::cout << std::hex << (cur_opcode & 0xFFFF) << std::endl;

	switch (cur_opcode & 0xF000)
	{
		case 0x0000:
		{
			switch (cur_opcode & 0x000F) //Some Opcodes have different endings
			{
				case 0x0000: // 0x00E0  Clears Screen
					{
						cleardisplay();
						drawFlag = true;
						p_count += 2;
						break;
					}
				case 0x000E:
					{
						--stck_ptr;
						p_count = stack[stck_ptr];
						//p_count += 2;
						break;
					}
				default:
				{
					std::cout << "Incorrect opcode: " << std::hex << (0xFFFF & cur_opcode) << std::endl;
					break;
				}
			}
		}
		
		case 0xA000:
		{
			I = cur_opcode & 0x0FFF;
			p_count += 2;
			break;
		}
		case 0x1000:
		{
			p_count = cur_opcode & 0x0FFF;
			break;
		}
		case 0x2000:
		{
			stack[stck_ptr] = p_count;
			stck_ptr++;
			p_count = cur_opcode & 0x0FFF;
			break;
		}
		case 0x3000:
		{
			if (V[(cur_opcode & 0x0F00) >> 8] == (cur_opcode & 0x00FF))
			{
				p_count += 4;
			}
			else
			{
				p_count += 2;
			}
			break;
		}
		case 0x4000:
		{
			if (V[(cur_opcode & 0x0F00) >> 8] != (cur_opcode & 0x00FF))
			{
				p_count += 4;
			}
			else
			{
				p_count += 2;
			}
			break;
		}
		case 0x5000:
		{
			if (V[(cur_opcode & 0x0F00) >> 8] == V[(cur_opcode & 0x00F00) >> 4])
			{
				p_count += 4;
			}
			else
			{
				p_count += 2;
			}
			break;
		}
		case 0x6000:
		{
			V[(cur_opcode & 0x0F00) >> 8] = cur_opcode & 0x00FF;
			p_count += 2;
			break;
		}
		case 0x7000:
		{
			V[(cur_opcode & 0x0F00) >> 8] = V[(cur_opcode & 0x0F00) >> 8] + (cur_opcode & 0x00FF);
			p_count += 2;
			break;
		}
		case 0x8000:
		{
			switch (cur_opcode & 0x000F)
			{
			case 0x0000:
			{
				V[(cur_opcode & 0x0F00) >> 8] = V[(cur_opcode & 0x00F0) >> 4];
				p_count += 2;
				break;
			}
			case 0x0001:
			{
				V[(cur_opcode & 0x0F00) >> 8] |= V[(cur_opcode & 0x00F0) >> 4];
				p_count += 2;
				break;
			}
			case 0x0002:
			{
				V[(cur_opcode & 0x0F00) >> 8] &= V[(cur_opcode & 0x00F0) >> 4];
				p_count += 2;
				break;
			}
			case 0x0003:
			{
				V[(cur_opcode & 0x0F00) >> 8] ^= V[(cur_opcode & 0x00F0) >> 4];
				p_count += 2;
				break;
			}
			case 0x0004: // Solution used by multigesture.net
			{
				if (V[(cur_opcode & 0x00F0) >> 4] > (0xFF - V[(cur_opcode & 0x0F00) >> 8]))
					V[0xF] = 1; //carry
				else
					V[0xF] = 0;
				V[(cur_opcode & 0x0F00) >> 8] += V[(cur_opcode & 0x00F0) >> 4];
				p_count += 2;
				break;
			}
			case 0x0005:
			{

				if (V[(cur_opcode & 0x00F0) >> 4] > V[(cur_opcode & 0x0F00) >> 8])
					V[0xF] = 0;
				else
					V[0xF] = 1;
				V[(cur_opcode & 0x0F00) >> 8] = V[(cur_opcode & 0x0F00) >> 8] - V[(cur_opcode & 0x00F0) >> 4];
				p_count += 2;
				break;
			}
			case 0x0006:
			{
				if ((V[(cur_opcode & 0x0F00) >> 8] & 0x1) == 0x1)
					V[0xF] = 1;
				else
					V[0xF] = 0;
				V[(cur_opcode & 0x0F00) >> 8] >>= 1;
				p_count += 2;
				break;
			}
			case 0x0007:
			{
				if (V[(cur_opcode & 0x0F00) >> 8] > V[(cur_opcode & 0x00F0) >> 4])
					V[0xF] = 0;
				else
					V[0xF] = 1;
				V[(cur_opcode & 0x0F00) >> 8] = V[(cur_opcode & 0x00F0) >> 4] - V[(cur_opcode & 0x0F00) >> 8];
				p_count += 2;
				break;
			}
			case 0x000E:
			{
				V[0xF] = V[(cur_opcode & 0x0F00) >> 8] >> 7;
				V[(cur_opcode & 0x0F00) >> 8] <<= 1;
				p_count += 2;
				break;
			}
			default:
			{
				std::cout << "Incorrect opcode: " << std::hex << (0xFFFF & cur_opcode) << std::endl;
				break;
			}
			}
			break;
		}
		case 0x9000:
		{
			if (V[(cur_opcode & 0x0F00) >> 8] != V[(cur_opcode & 0x00F0) >> 4])
				p_count += 4;
			else
				p_count += 2;
			break;
		}

		case 0xB000: 
		{
			p_count = (cur_opcode & 0x0FFF) + V[0];
			break;
		}
		case 0xC000:
		{
			srand(time(0));
			V[(cur_opcode & 0x0F00) >> 8] = (rand() % 0xFF) & (cur_opcode & 0x00FF);
			p_count += 2;
			break;
		}
		case 0xD000: // Used code from multigesture.net article and modified
		{
			unsigned short x = V[(cur_opcode & 0x0F00) >> 8];
			unsigned short y = V[(cur_opcode & 0x00F0) >> 4];
			unsigned short height = cur_opcode & 0x000F;
			unsigned short pixel;

			V[0xF] = 0;
			for (int yline = 0; yline < height; yline++)
			{
				pixel = memory[I + yline];
				for (int xline = 0; xline < 8; xline++)
				{
					if ((pixel & (0x80 >> xline)) != 0)
					{
						if (disp[(x + xline + ((y + yline) * 64)) % 2048] == 1)
							V[0xF] |= 1;
						disp[(x + xline + ((y + yline) * 64)) % 2048] ^= 1;
					}
				}
			}

			drawFlag = true;
			p_count += 2;
			break;
		}

		case 0xE000:
		{
			switch (cur_opcode & 0x00FF)
			{
				case 0x009E:
				{
					if (key[V[(cur_opcode & 0x0F00) >> 8]] != 0)
					{
						p_count += 4;
					}
					else
					{
						p_count += 2;
					}
					break;
				}
				case 0x00A1:
				{
					if (key[V[(cur_opcode & 0x0F00) >> 8]] == 0)
					{
						p_count += 4;
					}
					else
					{
						p_count += 2;
					}
					break;
				}
				default:
				{
					std::cout << "Incorrect opcode: " << std::hex << (0xFFFF & cur_opcode) << std::endl;
					break;
				}
			}
			break;
		}
			
		case 0xF000:
		{
			switch (cur_opcode & 0x00FF)
			{
				case 0x0007:
				{
					V[(cur_opcode & 0x0F00) >> 8] = delaytmr;
					p_count += 2;
					break;
				}
				case 0x000A:
				{
					bool key_pressed = false;
					for (int i = 0; i < 16; ++i)
					{
						if (key[i] != 0)
						{
							key_pressed = true;
							V[(cur_opcode & 0x0F00) >> 8] = i;
						}
					}
					if (!key_pressed)
					{
						return;
					}
					p_count += 2;
					break;
				}
				case 0x0015:
				{
					delaytmr = V[(cur_opcode & 0x0F00) >> 8];
					p_count += 2;
					break;
				}
				case 0x0018:
				{
					soundtmr = V[(cur_opcode & 0x0F00) >> 8];
					p_count += 2;
					break;
				}
				case 0x001E:
				{
					if (I + V[(cur_opcode & 0x0F00) >> 8] > 0xFFF)
					{
						V[0xF] = 1;
					}
					else
					{
						V[0xF] = 0;
					}
					I += V[(cur_opcode & 0x0F00) >> 8];
					p_count += 2;
					break;
				}
				case 0x0029:
				{
					I = V[(cur_opcode & 0x0F00) >> 8] * 0x5;
					p_count += 2;
					break;
				}
				case 0x0033:
				{
					memory[I] = V[(cur_opcode & 0x0F00) >> 8] / 100;
					memory[I + 1] = (V[(cur_opcode & 0x0F00) >> 8] / 10) % 10;
					memory[I + 2] = (V[(cur_opcode & 0x0F00) >> 8] % 100) % 10;
					p_count += 2;
					break;
				}
				case 0x0055:
				{
					for (int i = 0; i <= ((cur_opcode & 0x0F00) >> 8); ++i)
					{
						memory[I + i] = V[i];
					}
					
					p_count += 2;
					break;
				}
				case 0x0065:
				{
					for (int i = 0; i <= ((cur_opcode & 0x0F00) >> 8); ++i)
					{
						V[i] = memory[I + i];
					}
					
					p_count += 2;
					break;
				}
				default:
				{
					std::cout << "Incorrect opcode: " << std::hex << (0xFFFF & cur_opcode) << std::endl;
					break;
				}
			}
			break;
		}

		default:
		{
			std::cout << "Incorrect opcode: " << std::hex << (0xFFFF & cur_opcode) << std::endl;
			break;
		}
	}

	//Updating Timers
	if (delaytmr > 0)
		--delaytmr;
	if (soundtmr > 0)
	{
		if (soundtmr == 1)
			beepsound.play();
		--soundtmr;
	}

}

void CHIP_8::cleardisplay() // CLEARS Display
{
	for (int i = 0; i < 64 * 32; ++i) 
	{
		disp[i] = 0;
	}

}
