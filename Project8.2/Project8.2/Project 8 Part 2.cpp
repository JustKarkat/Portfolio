//*********************************************************************** 
 //																		*
 //		Assingment:		#8												*
 //																		*
 //		File:			Project 8 Part 2.cpp						    *
 //																		*
 //		Due Date:		September 27 2019								*
 //																		*
 //		Author:			Joshua Russell							        *
 //																		*
 //		Course Name:	Programming I									*
 //																		*
 //		Course Number:	COSC 1550										*
 //																		*
 //		Description:	Calculates the cost of baseballs.	            *
 //																		*
 //																		*
 //***********************************************************************

#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
	int numberOfBaseballs = 1;
	const int TWO = 4,
			  ONE = 7;
	double totalcost = 0.00;

	cout << "How many baseballs do you want: " << fixed << showpoint << setprecision(2);

	cin >> numberOfBaseballs;
	if (numberOfBaseballs % 2)
	{
		totalcost = ((numberOfBaseballs / 2) * ONE) + TWO;
	}
	if (numberOfBaseballs / 2 && !(numberOfBaseballs % 2))
	{
		totalcost = (numberOfBaseballs / 2) * ONE;
	}
	cout << "The cost of " << numberOfBaseballs << " baseballs is $" << totalcost;
}

/*
OUTPUT:
//////////////
How many baseballs do you want: 1
The cost of 1 baseballs is $4.00
//////////////
How many baseballs do you want: 2
The cost of 2 baseballs is $7.00
//////////////
How many baseballs do you want: 13
The cost of 13 baseballs is $46.00
//////////////
How many baseballs do you want: 24
The cost of 24 baseballs is $84.00
*/