//*********************************************************************** 
 //																		*
 //		Assignment:		#14												*
 //																		*
 //		File:			Assignment 14.cpp								*
 //																		*
 //		Due Date:		October 30th								    *
 //																		*
 //		Author:			Joshua Russell							        *
 //																		*
 //		Course Name:	Programming I									*
 //																		*
 //		Course Number:	COSC 1550										*
 //																		*
 //		Description:	Displays the weekly payroll report.	            *
 //																		*
 //																		*
 //***********************************************************************

#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
	int emp_Num,
		gross_pay,
		witholdings,
		total_gross = 0,
		total_with = 0,
		total_net = 0;

	do
	{
		cout << "Enter an Employee Number (must be positive) or \"0\" to quit: ";
		cin >> emp_Num;
		if (emp_Num == 0)
		{
			break;
		}
		while (emp_Num < 0)
		{
			cout << "Employee # must be positive: ";
			cin >> emp_Num;
		}

		cout << "Enter gross pay (must be greater than 0): ";
		cin >> gross_pay;
		while (gross_pay <= 0)
		{
			cout << "Gross pay must be greater than 0\n";
			cout << "Enter gross pay (must be greater than 0): ";
			cin >> gross_pay;
		}

		cout << "Enter witholdings: ";
		cin >> witholdings;
		while (witholdings > gross_pay)
		{
			cout << "Enter witholdings (must be less than gross pay): ";
			cin >> witholdings;
		}

		total_gross += gross_pay;
		total_with += witholdings;
		total_net = total_gross - total_with;

	} while (emp_Num != 0);

	cout << left << setw(20) << "\n\nTotal Gross Pay:" << right << setw(11) << "$" << total_gross;
	cout << left << setw(20) << "\nTotal Witholdings:" << right << setw(10) << "$" << total_with;
	cout << left << setw(20) << "\nTotal net:" << right << setw(10) << "$" << total_net;

}

/*
OUTPUT:
Enter an Employee Number (must be positive) or "0" to quit: 1
Enter gross pay (must be greater than 0): -200
Gross pay must be greater than 0
Enter gross pay (must be greater than 0): 200
Enter witholdings: 0
Enter an Employee Number (must be positive) or "0" to quit: 2
Enter gross pay (must be greater than 0): 300
Enter witholdings: 400
Enter witholdings (must be less than gross pay): 20
Enter an Employee Number (must be positive) or "0" to quit: 0


Total Gross Pay:            $500
Total Witholdings:          $20
Total net:                  $480

*/