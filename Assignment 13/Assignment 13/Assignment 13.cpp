//*********************************************************************** 
 //																		*
 //		Assingment:		#13												*
 //																		*
 //		File:			Assignment 13.cpp								*
 //																		*
 //		Due Date:		October 30										*
 //																		*
 //		Author:			Joshua Russell							        *
 //																		*
 //		Course Name:	Programming I									*
 //																		*
 //		Course Number:	COSC 1550										*
 //																		*
 //		Description:	A math tutoring program that loops.   	        *
 //						does +, -, *, and /                 			*
 //																		*
 //***********************************************************************

#include <iostream>
#include <ctime>
#include <random>
#include <iomanip>
using namespace std;

int main()
{
	unsigned int seed;
	int user_input;
	float number1;
	float number2;
	float answer;


	do
	{
		seed = rand() + time(0);
		srand(seed);

		number1 = rand() % 51;
		number2 = rand() % 51;

		cout << "Menu\n" << setprecision(2) << fixed << showpoint;
		cout << "1. Addition Problem\n";
		cout << "2. Subtraction Problem\n";
		cout << "3. Multiplication Problem\n";
		cout << "3. Division Problem\n";
		cout << "5. Quit...\n";
		cout << "Make your selection (1-5): ";
		cin >> user_input;
		while (user_input < 1 || user_input > 5)
		{
			cout << "Enter a selection between 1 and 5: ";
			cin >> user_input;
		}
		switch(user_input)
		{
		case 1:
		{
			cout << "Addition Problem:\n";
			cout << "Enter the correct answer:\n";
			cout << number1 << " + " << number2 << " = ";
			cin >> answer;
			if (answer == (number1 + number2))
			{
				cout << "Correct!\n";
			}
			else
			{
				cout << "Incorrect!\n";
				cout << "The correct answer was " << number1 + number2 << endl;
			}
			break;
		}
		case 2:
		{
			cout << "Subtraction Problem:\n";
			cout << "Enter the correct answer:\n";
			cout << number1 << " - " << number2 << " = ";
			cin >> answer;
			if (answer == (number1 - number2))
			{
				cout << "Correct!\n";
			}
			else
			{
				cout << "Incorrect!\n";
				cout << "The correct answer was " << number1 - number2 << endl;
			}
			break;
		}
		case 3:
		{
			cout << "Multiplication Problem:\n";
			cout << "Enter the correct answer:\n";
			cout << number1 << " * " << number2 << " = ";
			cin >> answer;
			if (answer == (number1 * number2))
			{
				cout << "Correct!\n";
			}
			else
			{
				cout << "Incorrect!\n";
				cout << "The correct answer was " << number1 * number2 << endl;
			}
			break;
		}
		case 4:
		{
			cout << "Division Problem:\n";
			cout << "Enter the correct answer:\n";
			cout << number1 << " / " << number2 << " = ";
			cin >> answer;
			if (abs(answer - (number1/number2)) <= 0.01) // ignores rounding errors
			{
				cout << "Correct!\n";
			}
			else
			{
				cout << "Incorrect!\n";
				cout << "The correct answer was " << number1 / number2 << endl;
			}
			break;
		}
		default:
			cout << "Quitting...\n";
			break;
		}



	} while (user_input != 5);
}

/*
OUTPUT:
Menu
1. Addition Problem
2. Subtraction Problem
3. Multiplication Problem
3. Division Problem
5. Quit...
Make your selection (1-5): 1
Addition Problem:
Enter the correct answer:
19.00 + 15.00 = 1
Incorrect!
The correct answer was 34.00
Menu
1. Addition Problem
2. Subtraction Problem
3. Multiplication Problem
3. Division Problem
5. Quit...
Make your selection (1-5): 2
Subtraction Problem:
Enter the correct answer:
2.00 - 12.00 = -10
Correct!
Menu
1. Addition Problem
2. Subtraction Problem
3. Multiplication Problem
3. Division Problem
5. Quit...
Make your selection (1-5): 4
Division Problem:
Enter the correct answer:
41.00 / 28.00 = 1.46
Correct!
Menu
1. Addition Problem
2. Subtraction Problem
3. Multiplication Problem
3. Division Problem
5. Quit...
Make your selection (1-5): 3
Multiplication Problem:
Enter the correct answer:
44.00 * 27.00 = 1188
Correct!
Menu
1. Addition Problem
2. Subtraction Problem
3. Multiplication Problem
3. Division Problem
5. Quit...
Make your selection (1-5): 5
Quitting...

*/