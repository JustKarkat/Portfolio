//*********************************************************************** 
 //																		*
 //		Assignment:		#21												*
 //																		*
 //		File:			Assignment21.cpp								*
 //																		*
 //		Due Date:		December 9th 2019								*
 //																		*
 //		Author:			Joshua Russell						        	*
 //																		*
 //		Course Name:	Programming I									*
 //																		*
 //		Course Number:	COSC 1550										*
 //																		*
 //		Description:	Works scores for 3 students and 4 tests each.	*
 //																		*
 //																		*
 //***********************************************************************

#include <iostream>
#include <iomanip>
#include <fstream>
using namespace std;

//Global Variables

const int TESTS = 4;
const int STUDENTS = 3;

//Prototypes

void getTests(double[][TESTS]);
double totalTests(double[][TESTS]);
double averageTest(double);
void averageEachTest(double[][TESTS]);
void averageEachStudent(double[][TESTS]);
double getHighest(double[][TESTS]);
void getHighestOfEachTest(double[][TESTS]);
void getLowestOfEachStudent(double[][TESTS]);
void report(double[][TESTS], double, double, double);

void wait();

int main()
{
	double tests[STUDENTS][TESTS];

	getTests(tests);

	double total = totalTests(tests);
	double average = averageTest(total);
	double highest = getHighest(tests);

	report(tests, total, average, highest);

}

//******************************************
// Gets tests from test.txt file
void getTests(double tests[STUDENTS][TESTS])
{
	ifstream file;
	file.open("test.txt");
	if (!file)
	{
		cout << "File not found..." << endl;
		wait();
		exit(0);
	}

	for (int i = 0; i < STUDENTS; i++)
	{
		for (int j = 0; j < TESTS; j++)
		{
			file >> tests[i][j];
		}
	}
}
//******************************************
// Gets total of all tests for all students
double totalTests(double tests[STUDENTS][TESTS])
{
	double totaltests = 0;
	for (int i = 0; i < STUDENTS; i++)
	{
		for (int j = 0; j < TESTS; j++)
		{
			totaltests += tests[i][j];
		}
	}
	return totaltests;
}
//******************************************
// Gets the average for all tests for all students
double averageTest(double total)
{
	double average = total / STUDENTS * TESTS;
	return average;
}

//******************************************
// Gets average for each Test.
void averageEachTest(double tests[STUDENTS][TESTS])
{
	double totalpertest[TESTS] = { 0 };
	for (int i = 0; i < STUDENTS; i++)
	{
		for (int j = 0; j < TESTS; j++)
		{
			totalpertest[j] += tests[i][j];
		}
	}
	for (int test = 0; test < TESTS; test++)
	{
		cout << "The average for test #" << test + 1 << ": " << totalpertest[test] / STUDENTS << endl;
	}
	wait();
}

//******************************************
// Gets average for each Student.
void averageEachStudent(double tests[STUDENTS][TESTS])
{
	double totalperstudent[STUDENTS] = { 0 };
	for (int i = 0; i < STUDENTS; i++)
	{
		for (int j = 0; j < TESTS; j++)
		{
			totalperstudent[i] += tests[i][j];
		}
	}
	for (int students = 0; students < STUDENTS; students++)
	{
		cout << "The average for Student #" << students + 1 << ": " << totalperstudent[students] / TESTS << endl;
	}
	wait();
}
//******************************************
// Gets highest overall.
double getHighest(double tests[STUDENTS][TESTS])
{
	double highest = tests[0][0];
	for (int i = 0; i < STUDENTS; i++)
	{
		for (int j = 0; j < TESTS; j++)
		{
			if (highest < tests[i][j])
			{
				highest = tests[i][j];
			}
		}
	}
	return highest;
	wait();
}

//******************************************
// Gets highest for each Test.
void getHighestOfEachTest(double tests[STUDENTS][TESTS])
{
	double highest[TESTS] = { 0 };
	for (int i = 0; i < STUDENTS; i++)
	{
		for (int j = 0; j < TESTS; j++)
		{
			if (highest[j] < tests[i][j])
			{
				highest[j] = tests[i][j];
			}
		}
	}
	for (int test = 0; test < TESTS; test++)
	{
		cout << "The highest for test #" << test + 1 << ": " << highest[test] << endl;
	}
	wait();
}

//******************************************
// Gets lowest for each Student.
void getLowestOfEachStudent(double tests[STUDENTS][TESTS])
{
	double lowest[STUDENTS] = { 0 };
	for (int i = 0; i < STUDENTS; i++)
	{
		lowest[i] = tests[i][0];
		for (int j = 0; j < TESTS; j++)
		{
			if (lowest[i] > tests[i][j])
			{
				lowest[i] = tests[i][j];
			}
		}
	}
	for (int students = 0; students < STUDENTS; students++)
	{
		cout << "The lowest score for Student #" << students + 1 << ": " << lowest[students] << endl;
	}
	wait();
}

//******************************************
// reports all data.
void report(double tests[STUDENTS][TESTS], double t, double a, double h)
{

	cout << "The total of all tests is: " << t << endl;
	wait();
	cout << "The average of all tests is: " << a << endl;
	wait();
	cout << "The highest of all tests is: " << h << endl;
	wait();
	averageEachTest(tests);
	averageEachStudent(tests);
	getHighestOfEachTest(tests);
	getLowestOfEachStudent(tests);
}

//***********************************************************************
// Asks user to press enter to continue and waits for input.
void wait()
{
	cout << "Press Enter to Continue..." << fixed << showpoint << setprecision(2);
	cin.ignore();
	cout << endl;
}

/*
OUTPUT:

The total of all tests is: 955
Press Enter to Continue...

The average of all tests is: 1273.33
Press Enter to Continue...

The highest of all tests is: 90.00
Press Enter to Continue...

The average for test #1: 78.33
The average for test #2: 86.67
The average for test #3: 76.67
The average for test #4: 76.67
Press Enter to Continue...

The average for Student #1: 78.75
The average for Student #2: 78.75
The average for Student #3: 81.25
Press Enter to Continue...

The highest for test #1: 85.00
The highest for test #2: 90.00
The highest for test #3: 90.00
The highest for test #4: 80.00
Press Enter to Continue...

The lowest score for Student #1: 70.00
The lowest score for Student #2: 60.00
The lowest score for Student #3: 75.00
Press Enter to Continue...


*/