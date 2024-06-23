//*********************************************************************** 
 //																		*
 //		Assingment:		#10												*
 //																		*
 //		File:			Assignment 10.cpp								*
 //																		*
 //		Due Date:		October 4 2019								    *
 //																		*
 //		Author:			Joshua Russell							        *
 //																		*
 //		Course Name:	Programming I									*
 //																		*
 //		Course Number:	COSC 1550										*
 //																		*
 //		Description:	Checks Social Security Eligibility	            *
 //																		*
 //																		*
 //***********************************************************************

#include <iostream>

using namespace std;

int main()
{
	unsigned int age;
	char gender;

	cout << "Enter your gender. (M or F): ";
	cin.get(gender);
	gender = toupper(gender);

	while (gender != 'M' && gender != 'F')
	{
		cout << "Error.\nEnter your gender. (M or F): ";
		cin >> gender;
	}
	if (gender == 'M')
	{
		cout << "Enter your age: ";
		cin >> age;
		while (age < 0 || age > 110)
		{
			cout << "Error.\nEnter your age: ";
			cin >> age;
		}
		if (age >= 65)
		{
			cout << "You are eligible for 100$ benefits per month.\n";
		}
		else
		{
			cout << "You are ineliglbe for benefits. " << 65 - age << " years until eligible (must be 65 years of age).";
		}
	}
	if (gender == 'F')
	{
		cout << "Enter your age: ";
		cin >> age;
		while (age < 0 || age > 110)
		{
			cout << "Error.\nEnter your age: ";
			cin >> age;
		}
		if (age >= 60)
		{
			cout << "You are eligible for 180$ benefits per month.\n";
		}
		else
		{
			cout << "You are ineliglbe for benefits. " << 60 - age << " years until eligible (must be 60 years of age).";
		}
	}
}

/*
OUTPUT:
Enter your gender. (M or F): m
Enter your age: 55
You are ineliglbe for benefits. 10 years until eligible (must be 65 years of age).
////
Enter your gender. (M or F): m
Enter your age: 68
You are eligible for 100$ benefits per month.
////
Enter your gender. (M or F): f
Enter your age: 45
You are ineliglbe for benefits. 15 years until eligible (must be 60 years of age).
////
Enter your gender. (M or F): f
Enter your age: 62
You are eligible for 180$ benefits per month.

*/