//*********************************************************************** 
 //																		*
 //		Assingment:		#8												*
 //																		*
 //		File:			8 Part 1.cpp							    	*
 //																		*
 //		Due Date:		September 27 2019								*
 //																		*
 //		Author:			Joshua Russell							        *
 //																		*
 //		Course Name:	Programming I									*
 //																		*
 //		Course Number:	COSC 1550										*
 //																		*
 //		Description:	This program calculates taxes on sales.	        *
 //																		*
 //																		*
 //***********************************************************************

#include <iostream>
#include <iomanip>
#include <string>
using namespace std;

int main()
{
	double total;
	int month;
	string storedMonth;
	const double COUNTRY = 0.02,
				 STATE = 0.04;
	double sales,
		countryTax,
		stateTax,
		totalTax;

	cout << "Enter the total ammount collected: ";
	cin >> total;
	cout << "Enter what month it is for (1-12): ";
	cin >> month;
	cout << endl;
	if (month <= 12 && month > 0)
	{
		if (month == 1)
		{
			storedMonth = "January";
		}
		if (month == 2)
		{
			storedMonth = "February";
		}
		if (month == 3)
		{
			storedMonth = "March";
		}
		if (month == 4)
		{
			storedMonth = "April";
		}
		if (month == 5)
		{
			storedMonth = "May";
		}
		if (month == 6)
		{
			storedMonth = "June";
		}
		if (month == 7)
		{
			storedMonth = "July";
		}
		if (month == 8)
		{
			storedMonth = "August";
		}
		if (month == 9)
		{
			storedMonth = "September";
		}
		if (month == 10)
		{
			storedMonth = "October";
		}
		if (month == 11)
		{
			storedMonth = "November";
		}
		if (month == 12)
		{
			storedMonth = "December";
		}
	}
	else
	{
		cout << "Incorrect, enter a month between 1 and 12" << endl;
		return 0;
	}
	sales = total / (STATE + COUNTRY + 1);
	countryTax = sales * COUNTRY;
	stateTax = sales * STATE;
	totalTax = stateTax + countryTax;
	cout << fixed << setprecision(2) << showpoint;
	cout << "Month: " << storedMonth << endl;
	cout << "---------------------- \n";
	cout << left << setw(24) << "Total Collected: " << right << "$" << setw(9) << total << endl;
	cout << left << setw(24) << "Sales: " << right << "$" << setw(9) << sales << endl;
	cout << left << setw(24) << "Country Sales Tax: " << right << "$" << setw(9) << countryTax << endl;
	cout << left << setw(24) << "State Sales Tax: " << right << "$" << setw(9) << stateTax << endl;
	cout << left << setw(24) << "Total Sales Tax: " << right << "$" << setw(9) << totalTax << endl;
}

/* OUTPUT:
//////////////////////
Enter the total ammount collected: 1234.56
Enter what month it is for (1-12): 1

Month: January
----------------------
Total Collected:        $  1234.56
Sales:                  $  1164.68
Country Sales Tax:      $    23.29
State Sales Tax:        $    46.59
Total Sales Tax:        $    69.88
///////////////////////
Enter the total ammount collected: 78910.11
Enter what month it is for (1-12): 2

Month: February
----------------------
Total Collected:        $ 78910.11
Sales:                  $ 74443.50
Country Sales Tax:      $  1488.87
State Sales Tax:        $  2977.74
Total Sales Tax:        $  4466.61
///////////////////////
Enter the total ammount collected: 1337.33
Enter what month it is for (1-12): 7

Month: July
----------------------
Total Collected:        $  1337.33
Sales:                  $  1261.63
Country Sales Tax:      $    25.23
State Sales Tax:        $    50.47
Total Sales Tax:        $    75.70
*/