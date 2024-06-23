//*****************************************************
//
//  Assignment:  #3
//
//  File:  Project 3.cpp
//
//  Due Date:  Sept 6 2019
//
//  Author:  Joshua Russell
//
//  Course Name:  Programming 1
//
//  Course Number:  COSC 1550
//
//  Description:  This program responds with the
//                floor number and room number.
//*****************************************************


#include <iostream>
#include <iomanip>
#include <string>
using namespace std;

int main()
{
	int fullNumber = 0;
	int roomNumber;
	int floorNumber;

	cout << "Enter your number: ";
	cin >> fullNumber;

	roomNumber = fullNumber % 100;
	floorNumber = fullNumber / 100;
	cout << "Your room number is " << roomNumber << endl;
	cout << "Your floor number is " << floorNumber << endl;

	return 0;

}

/*
Output:
Enter your number: 312
Your room number is 12
Your floor number is 3

C:\Users\****\source\repos\Assignment3\Debug\Assignment3.exe (process 11916) exited with code 0.
To automatically close the console when debugging stops, enable Tools->Options->Debugging->Automatically close the console when debugging stops.
Press any key to close this window . . .
//////
Enter your number: 412
Your room number is 12
Your floor number is 4

C:\Users\russe\source\repos\Assignment3\Debug\Assignment3.exe (process 11324) exited with code 0.
To automatically close the console when debugging stops, enable Tools->Options->Debugging->Automatically close the console when debugging stops.
Press any key to close this window . . .
//////



*/