#pragma once
#include <string>
#include <SFML/graphics.hpp>
class CHIP_8 //My First Emulator
{
	/*
	
		0x000-0x1FF - Chip 8 interpreter (contains font set in emu)
		0x050-0x0A0 - Used for the built in 4x5 pixel font set (0-F)
		0x200-0xFFF - Program ROM and work RAM
		
		Not pretending I did this alone, used multigesture.net article
	
	*/
public:
	CHIP_8();
	~CHIP_8();

	void initialize(); // initialize cpu and registers
	void emulateCycle(); // emulate a CPU cycle
	void loadGame(char[64]); // Load the chosen game into Memory
	void cleardisplay();

public: // PARTS OF THE SYSTEM

	unsigned short cur_opcode;
	unsigned char  memory[4096];

	unsigned char  V[16]; // 15 8-bit registers and 16th for carry flag

	unsigned short I; // Stores Memory Addresses (Lower Right 12 generally used [lifted from docs]) 0x000 - 0xFFF
	unsigned short p_count; // program counter 0x000 - 0xFFF

	unsigned char  disp[64 * 32]; //Graphics display, 64 x 32 pixels (monochrome)

	unsigned char delaytmr; // delay timer (count at 60hz to 0 when set above 0)
	unsigned char soundtmr; // sound timer

	unsigned short stack[16]; // stores stack when subroutine called
	unsigned short stck_ptr; // stack pointer

	unsigned char key[16]; // Keypad (HEX based - 0x0-0xF)

	bool clrscr = false;
	bool drawFlag = true;


};

