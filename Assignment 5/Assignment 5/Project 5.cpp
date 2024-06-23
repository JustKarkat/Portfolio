//*****************************************************
//
//  Assignment:  #5
//
//  File:  Project 5.cpp
//
//  Due Date:  Sept 6 2019
//
//  Author:  Joshua Russell
//
//  Course Name:  Programming 1
//
//  Course Number:  COSC 1550
//
//  Description:  This program calculates Miles Per
//                Gallon. (includes out to file)
//*****************************************************

#include <iostream>
#include <string>
#include <iomanip>
#include <fstream>
using namespace std;


double calculate(double milesDriven, double gallonsUsed) { //Creates a calculation function for Miles Per Gallon.
	double milesPerGallon = milesDriven / gallonsUsed;
	return milesPerGallon;
}


int main()
{
	cout << setprecision(2) << fixed << showpoint; // Sets the precision to 2 decimal places, sets flags fixed and showpoint.
	
	double milesDriven,
			gallonsUsed,
			milesPerGallon;

	char continueCalculate = 'Y'; // char Variable that allows the loop.
	do{
		cout << "Enter how many miles you have driven: ";
		cin >> milesDriven;

		cout << endl << "Enter how many gallons of gas you used: ";
		cin >> gallonsUsed;

		milesPerGallon = calculate(milesDriven, gallonsUsed);

		cout << endl << "Your vehicle has an efficiency of " << milesPerGallon << "MPG (Miles Per Gallon)" << endl << endl;

		char printToFile = 'n';
		cout << "Would you like to save to file? (Y/N): ";
		cin >> printToFile;
		if (printToFile == 'Y') {
			string fileName; // Save to file
			cout << "Enter file name: " << endl;
			cin >> fileName;
			std::ofstream outfile(fileName + ".txt");
			outfile << milesPerGallon << " Miles Per Gallon" << endl;
		}
		else if (printToFile == 'y') {
			string fileName; // Save to file
			cout << "Enter file name: " << endl;
			cin >> fileName;
			std::ofstream outfile(fileName + ".txt");
			outfile << milesPerGallon << " Miles Per Gallon" << endl;
		}

		cout << endl << "Would you like to continue? (Y/N): ";

		cin >> continueCalculate;
		cout << endl;

	} while (continueCalculate != 'N' && continueCalculate != 'n'); // A while loop so you can calculate again.
	system("pause"); //pauses the system so I could copy the output.
}
