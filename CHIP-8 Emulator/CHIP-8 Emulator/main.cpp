#include "CHIP_8.h"
#include <SFML\Window.hpp>
#include <SFML\OpenGL.hpp>
#include <iostream>
#include <string>
#include <gl\GL.h>
#include <gl\GLU.h>

CHIP_8 cpu;

int main(int argc, char **argv)
{
	while (true)
	{
		cpu.initialize(); // initializes the cpu registers
		char file_location[64];
		std::cout << "ENTER FILE LOCATION: ";
		std::cin.getline(file_location, 64);
		cpu.loadGame(file_location);

		sf::Window window(sf::VideoMode(640, 320), "CHIP-8 Emulator", sf::Style::Default, sf::ContextSettings(32));
		sf::Time previous_time;
		sf::Clock clock;
		int window_size = static_cast<int>((640 * 320));
		while (window.isOpen())
		{

			//HANDLE EVENTS
			sf::Event event;

			while (window.pollEvent(event))
			{
				// "close requested" event: we close the window
				if (event.type == sf::Event::Closed)
					window.close();
				if (event.type == sf::Event::Resized)
				{
					glViewport(0, 0, event.size.width, event.size.height);
					window_size = static_cast<int>((event.size.width * event.size.height));
				}
			}

			//UPDATES

			

			cpu.emulateCycle();

			while (clock.getElapsedTime().asMilliseconds() < (previous_time.asMilliseconds() + 1.0 / 60)) {
				Sleep(1);
			}

			for (int i = 0; i < 16; ++i)
			{
				cpu.key[i] = 0x0;
			}

			//Keypress on
			if (sf::Keyboard::isKeyPressed(sf::Keyboard::Num1))
				cpu.key[0] = 0x1;
			if (sf::Keyboard::isKeyPressed(sf::Keyboard::Num2))
				cpu.key[1] = 0x1;
			if (sf::Keyboard::isKeyPressed(sf::Keyboard::Num3))
				cpu.key[2] = 0x1;
			if (sf::Keyboard::isKeyPressed(sf::Keyboard::Num4))
				cpu.key[3] = 0x1;
			if (sf::Keyboard::isKeyPressed(sf::Keyboard::Q))
				cpu.key[4] = 0x1;
			if (sf::Keyboard::isKeyPressed(sf::Keyboard::W))
				cpu.key[5] = 0x1;
			if (sf::Keyboard::isKeyPressed(sf::Keyboard::E))
				cpu.key[6] = 0x1;
			if (sf::Keyboard::isKeyPressed(sf::Keyboard::R))
				cpu.key[7] = 0x1;
			if (sf::Keyboard::isKeyPressed(sf::Keyboard::A))
				cpu.key[8] = 0x1;
			if (sf::Keyboard::isKeyPressed(sf::Keyboard::S))
				cpu.key[9] = 0x1;
			if (sf::Keyboard::isKeyPressed(sf::Keyboard::D))
				cpu.key[10] = 0x1;
			if (sf::Keyboard::isKeyPressed(sf::Keyboard::F))
				cpu.key[11] = 0x1;
			if (sf::Keyboard::isKeyPressed(sf::Keyboard::Z))
				cpu.key[12] = 0x1;
			if (sf::Keyboard::isKeyPressed(sf::Keyboard::X))
				cpu.key[13] = 0x1;
			if (sf::Keyboard::isKeyPressed(sf::Keyboard::C))
				cpu.key[14] = 0x1;
			if (sf::Keyboard::isKeyPressed(sf::Keyboard::V))
				cpu.key[15] = 0x1;



			glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);
			glMatrixMode(GL_PROJECTION);
			glLoadIdentity();
			gluOrtho2D(0.0, 640, 320, 0.0);
			glPointSize(window_size / (64 * 32 * 10));
			glBegin(GL_POINTS);

			//DRAW OBJECTS
			if (cpu.drawFlag = true)
			{
				for (int y = 0; y < 32; ++y)
				{
					for (int x = 0; x < 64; ++x)
					{
						if (cpu.disp[(y * 64) + x] == 1)
						{
							glColor3f(1, 1, 1);
							glVertex2i((x * 10) + 5, y * 10);
						}
					}
				}
			}
			glEnd();
			window.display();
			//cpu.debugRender();

			previous_time = clock.getElapsedTime();

			if (sf::Keyboard::isKeyPressed(sf::Keyboard::Escape))
				window.close();
			
		}
		system("cls");
	}
	return 0;

}
