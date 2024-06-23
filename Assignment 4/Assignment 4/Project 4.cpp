//*****************************************************
//
//  Assignment:  #4
//
//  File:  Project 4.cpp
//
//  Due Date:  Sept 6 2019
//
//  Author:  Joshua Russell
//
//  Course Name:  Programming 1
//
//  Course Number:  COSC 1550
//
//  Description:  This program prints bytes for
//                char, int, float, and double.
//*****************************************************


#include <iostream>
#include <iomanip>
#include <string>
using namespace std;

int main()
{
	char charSize;
	int intSize;
	float floatSize;
	double doubleSize;

	cout << "A char is " << sizeof(charSize) << " bytes long." << endl;
	cout << "A int is " << sizeof(intSize) << " bytes long." << endl;
	cout << "A float is " << sizeof(floatSize) << " bytes long." << endl;
	cout << "A double is " << sizeof(doubleSize) << " bytes long." << endl;


}
/*
A char is 1 bytes long.
A int is 4 bytes long.
A float is 4 bytes long.
A double is 8 bytes long.

C:\Users\russe\source\repos\Assignment 4\Debug\Assignment 4.exe (process 8700) exited with code 0.
To automatically close the console when debugging stops, enable Tools->Options->Debugging->Automatically close the console when debugging stops.
Press any key to close this window . . .



*/