// ConsoleApplication1.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include "pch.h"
#include <iostream>
using namespace std;
void Sender();
int calc(int*, int*, int, int);

int main()
{
	int c = 0;
	char choice;
	do
	{
		cout << "Please choose if you are the sender or recever (S = Sender R = Recever)" << endl;
		cin >> choice;
		switch (toupper(choice))
		{
		case 'S':
		{
			cout << "Sender" << endl;
			Sender();
			c = 1;
			break;
		}
		case 'R':
		{
			cout << "Recever" << endl;
			c = 1;
			break;
		}
		default:
		{
			system("CLS");
			cout << "Not a valid Choice Please choose again" << endl;

			break;
		}
		}
	} while (c == 0);
}

void Sender()
{
	int genBits = 4;
	int dataBits = 6;
	int input[] = { 1,0,0,1 };
	int input2[] = { 1,0,1,1,1,0 };

	/* cout << "How many bits does the generator have?" << endl;
	 cin >> genBits;
	 cout << "How many bits does the data have?" << endl;
	 cin >> dataBits;
	 cout << "Please enter the generator seperated by spaces" << endl;
	 cin >> gen;
	 cout << "Please enter the Data seperated by spaces" << endl;
	 cin >> data;
	 */


	calc(input, input2, genBits, dataBits);




}

int calc(int* input, int* data, int genBits, int dataBits)
{
	int max_X;
	int max_Y;
	int current_X;
	int current_Y;

	return 0;
}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
