//*********************************************************************** 
 //																		*
 //		Assingment:		#9												*
 //																		*
 //		File:			Project 9.cpp      							    *
 //																		*
 //		Due Date:		October 4 2019              					*
 //																		*
 //		Author:			Joshua Russell							        *
 //																		*
 //		Course Name:	Programming I									*
 //																		*
 //		Course Number:	COSC 1550										*
 //																		*
 //		Description:	This program calculates the Area of different   *
 //						Geometrical shapes.	    						*
 //																		*
 //***********************************************************************

#include <iostream>
#include <iomanip>
using namespace std;

int main()
{

	const double PI = 3.14159;
	int choice;
	double input1 = 0;
	double input2 = 0;
	double output;

	cout << "Geometry Calculator\n" << fixed << showpoint << setprecision(2);
	cout << "     " << "1. Calculate the Area of a Circle\n";
	cout << "     " << "2. Calculate the Area of a Rectangle\n";
	cout << "     " << "3. Calculate the Area of a Triangle\n";
	cout << "     " << "4. Quit\n";
	cout << "Enter your choice (1-4): ";

	cin >> choice;

	while (choice < 1 || choice > 4)
	{
		cout << "Please enter a choice between 1 and 4.\n";
		cout << "Enter your choice (1-4): ";
		cin >> choice;
	}

		if (choice == 1)
		{
			cout << "Enter your circle's radius: ";
			cin >> input1;
			while (input1 < 0)
			{
				cout << "Please input a positive value for the radius.\nEnter your circles radius: ";
				cin >> input1;
			}
			cout << "\nYour circle has an area of " << input1 * input1*PI << " units squared.";
		}
		else if (choice == 2)
		{
			cout << "Enter your rectangles's length: ";
			cin >> input1;
			while (input1 < 0)
			{
				cout << "Please input a positive value for the length.\nEnter your rectangle's length: ";
				cin >> input1;
			}
			cout << "Enter your rectangles's width: ";
			cin >> input2;
			while (input2 < 0)
			{
				cout << "Please input a positive value for the width.\nEnter your rectangle's width: ";
				cin >> input2;
			}
			cout << "\nYour rectangle has an area of " << input1 * input2 << " units squared.";
		}
		else if (choice == 3)
		{
			cout << "Enter your triangles's base: ";
			cin >> input1;
			while (input1 < 0)
			{
				cout << "Please input a positive value for the base.\nEnter your rectangle's base: ";
				cin >> input1;
			}
			cout << "Enter your rectangles's height: ";
			cin >> input2;
			while (input2 < 0)
			{
				cout << "Please input a positive value for the height.\nEnter your rectangle's height: ";
				cin >> input2;
			}
			cout << "\nYour triangle has an area of " << .5 * input1 * input2 << " units squared.";
		}

	cout << "\nQuitting...\n";
}

/*
OUTPUT:
Geometry Calculator
	 1. Calculate the Area of a Circle
	 2. Calculate the Area of a Rectangle
	 3. Calculate the Area of a Triangle
	 4. Quit
Enter your choice (1-4): 1
Enter your circle's radius: -120
Please input a positive value for the radius.
Enter your circles radius: 5

Your circle has an area of 78.54 units squared.
Quitting...
////
Geometry Calculator
	 1. Calculate the Area of a Circle
	 2. Calculate the Area of a Rectangle
	 3. Calculate the Area of a Triangle
	 4. Quit
Enter your choice (1-4): 2
Enter your rectangles's length: 4
Enter your rectangles's width: 5

Your rectangle has an area of 20.00 units squared.
Quitting...
////
Geometry Calculator
	 1. Calculate the Area of a Circle
	 2. Calculate the Area of a Rectangle
	 3. Calculate the Area of a Triangle
	 4. Quit
Enter your choice (1-4): 3
Enter your triangles's base: 10
Enter your rectangles's height: 12

Your triangle has an area of 60.00 units squared.
Quitting...

*/