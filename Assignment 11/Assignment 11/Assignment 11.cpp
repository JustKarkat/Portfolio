//*********************************************************************** 
 //																		*
 //		Assingment:		#11												*
 //																		*
 //		File:			Assignment 11.cpp								*
 //																		*
 //		Due Date:		October 11										*
 //																		*
 //		Author:			Joshua Russell						        	*
 //																		*
 //		Course Name:	Programming I									*
 //																		*
 //		Course Number:	COSC 1550										*
 //																		*
 //		Description:	This program allows a user to calculate bill for*
 //						a phone plan.									*
 //																		*
 //***********************************************************************

#include <iostream>
#include <iomanip>

using namespace std;

int main()
{
	const double PACKAGE_A = 39.99,
		PACKAGE_B = 59.99,
		PACKAGE_C = 69.99,
		PACKAGE_A_ADDITIONAL = 0.45,
		PACKAGE_B_ADDITIONAL = 0.40;
	char choice = 'Z';
	int minutes;

	cout << "\t\tPackages\n";
	cout << "-------------------------------------------\n";
	cout << "Package A:    $39.99/month (450 minutes) + $0.45/minute over\n" << fixed << showpoint << setprecision(2);
	cout << "Package B:    $59.99/month (900 minutes) + $0.40/minute over\n";
	cout << "Package C:    $69.99/month (unlimited minutes)\n";
	cout << "-------------------------------------------\n";
	cout << "Which package did you subscribe to (A, B or C): ";
	cin >> choice;
	choice = toupper(choice);
	while (choice < 'A' || choice > 'C')
	{
		cout << "Invalid entry.\n";
		cout << "Which package did you subscribe to (A, B or C): ";
		cin >> choice;
		choice = toupper(choice);
		cout << endl;
	}

	cout << "How many minutes did you use: ";
	cin >> minutes;
	cout << endl;
	switch (choice)
	{
	case 'A':
	{
		if (minutes > 450)
		{
			minutes = minutes - 450;
		}
		else
		{
			minutes = 0;
		}

		cout << "Your bill is $" << PACKAGE_A + (minutes*PACKAGE_A_ADDITIONAL);
		break;
	}
	case 'B':
	{
		if (minutes > 900)
		{
			minutes = minutes - 900;
		}
		else
		{
			minutes = 0;
		}
		cout << "Your bill is $" << PACKAGE_B + (minutes*PACKAGE_B_ADDITIONAL);
		break;
	}
	case 'C':
	{
		cout << "Your bill is $" << PACKAGE_C << ". (You chose the unlimited package)";
		break;
	}
	}
	return 0;
}
/*
OUTPUT:





				Packages
-------------------------------------------
Package A:    $39.99/month (450 minutes) + $0.45/minute over
Package B:    $59.99/month (900 minutes) + $0.40/minute over
Package C:    $69.99/month (unlimited minutes)
-------------------------------------------
Which package did you subscribe to (A, B or C): a
How many minutes did you use: 600

Your bill is $107.49
////////////////////
				Packages
-------------------------------------------
Package A:    $39.99/month (450 minutes) + $0.45/minute over
Package B:    $59.99/month (900 minutes) + $0.40/minute over
Package C:    $69.99/month (unlimited minutes)
-------------------------------------------
Which package did you subscribe to (A, B or C): D
Invalid entry.
Which package did you subscribe to (A, B or C): q

Invalid entry.
Which package did you subscribe to (A, B or C): B

How many minutes did you use: 200

Your bill is $59.99
/////////////////
				Packages
-------------------------------------------
Package A:    $39.99/month (450 minutes) + $0.45/minute over
Package B:    $59.99/month (900 minutes) + $0.40/minute over
Package C:    $69.99/month (unlimited minutes)
-------------------------------------------
Which package did you subscribe to (A, B or C): C
How many minutes did you use: 123032302

Your bill is $69.99. (You chose the unlimited package)
*/