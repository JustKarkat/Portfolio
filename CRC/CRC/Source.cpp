//*********************************************************************** 
 //																		*
 //		Assingment:		#												*
 //																		*
 //		File:										*
 //																		*
 //		Due Date:												*
 //																		*
 //		Author:												*
 //																		*
 //		Course Name:										*
 //																		*
 //		Course Number:											*
 //																		*
 //		Description:	This program									*
 //																		*
 //																		*
 //***********************************************************************
#include <iostream>
#include <string>
#include <iomanip>
#include <vector>
#include <sstream>

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
	bool skip = true;
	int tempIndent = 0;
	int previndent = 0;
	int genBits = 4;
	int dataBits = 6;
	int input[] = { 1,0,0,1 };
	int input2[] = { 1,0,1,1,1,0 };
	int* gen = input;
	int* data = input2;

	/* cout << "How many bits does the generator have?" << endl;
	 cin >> genBits;
	 cout << "How many bits does the data have?" << endl;
	 cin >> dataBits;
	 cout << "Please enter the generator seperated by spaces" << endl;
	 cin >> gen;
	 cout << "Please enter the Data seperated by spaces" << endl;
	 cin >> data;
	 */
	int indent = genBits + 1;

	int array[100][100];

	for (int j = 0; j < genBits; j++)
	{
		array[j][0] = input[j];
	}
	array[genBits][0] = -1;
	for (int j = 0; j < dataBits; j++)
	{
		array[j + genBits + 1][0] = data[j];
	}
	for (int j = 0; j < genBits; j++)
	{
		array[j + genBits + dataBits + 1][0] = 0;
	}
	array[genBits + genBits + dataBits + 1][0] = -2;

	for (int k = 1; k < 20; k++)
	{
		for (int i = 0; i < indent; i++)
		{
			array[i][k] = -1;
		}

		for (int i = 0; i < genBits; i++)
		{
			array[i + indent][k] = input[i];
		}
		array[indent + genBits][k] = -2;
		k++;
		for (int i = 0; i <= indent; i++)
		{
			array[i][k] = -1;
		}
		skip = true;
		tempIndent = 0;
		for (int i = 0; i < genBits; i++)
		{
			array[i + indent][k] = array[i + indent][k - 2] ^ array[i + indent][k - 1];
			if (array[i + indent][k] == 0)
			{
				if (skip)
				{
					array[i + indent][k] = -1;
					tempIndent++;
				}

			}
			else if (array[i + indent][k] == 1)
			{
				skip = false;
			}

		}
		//cout << tempIndent << endl;
		//cout << indent << endl;
		indent = indent + tempIndent;
		for (int i = 0; i < tempIndent; i++)
		{
			array[i + indent + tempIndent][k] = array[i + indent + tempIndent][0];
		}
		int p = 0;
		p++;
		if (p > 1)
		{
			array[indent + tempIndent + tempIndent][k] = -2;
		}
		else
		{
			array[indent + tempIndent + tempIndent + 1][k] = -2;
		}




	}


	for (int j = 0; j < 10; j++)
	{
		for (int i = 0; i < 20; i++)
		{

			if (array[i][j] == -2)
			{
				cout << 'n' << endl;
				break;
			}
			else if (array[i][j] == -1)
			{
				cout << " ";
			}
			else
			{
				cout << array[i][j];
			}

		}
	}

}
