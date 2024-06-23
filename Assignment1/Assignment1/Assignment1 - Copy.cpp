//*********************************************************************** 
 //																		*
 //		Assignment:		#1												*
 //																		*
 //		File:			Assignment1.cpp								    *
 //																		*
 //		Due Date:		24 January 2020									*
 //																		*
 //		Author:			Joshua Russell						          	*
 //																		*
 //		Course Name:	Programming II								    *
 //																		*
 //		Course Number:	COSC 1550										*
 //																		*
 //		Description:	Reads input from File and prints student		*
 //						Total/Avg/Highest scores.						*
 //                                                                     *
 //     Other Necessary Files: Assignment1Data.txt                      *
 //																		*
 //***********************************************************************
#include <iostream>
#include <fstream>
#include <iomanip>
using namespace std;

const int NUM_STDNTS = 10;
const int NUM_TESTS = 8;
int testScores[NUM_STDNTS][NUM_TESTS];

//Prototypes
void readTestScores(ifstream&, int[][NUM_TESTS], int);
void displayTestScores(int[][NUM_TESTS], int);
int totalOneTest(const int[][NUM_TESTS], int, int);
int totalOneStudent(const int[][NUM_TESTS], int, int);
double averageOneTest(const int[][NUM_TESTS], int, int);
double averageOneStudent(const int[][NUM_TESTS], int, int);
int highestOneStudent(const int[][NUM_TESTS], int, int);
int topStudent(const int[][NUM_TESTS], int);
void wait();

int main()
{
	ifstream file("Assignment1Data.txt");
	readTestScores(file, testScores, NUM_STDNTS);
	displayTestScores(testScores, NUM_STDNTS);
	cout << endl << "Total for Test #" << 1 << " is: " << totalOneTest(testScores, NUM_STDNTS, 0); 
	wait();
	cout << endl << "Total for Test #" << 5 << " is: " << totalOneTest(testScores, NUM_STDNTS, 4);
	wait();
	cout << endl << "Total for Student #" << 3 << " is: " << totalOneStudent(testScores, NUM_STDNTS, 2);
	wait();
	cout << endl << "Total for Student #" << 8 << " is: " << totalOneStudent(testScores, NUM_STDNTS, 7);
	wait(); 
	cout << endl << fixed << showpoint << setprecision(2) << "Average for Test #" << 5 << " is: " << averageOneTest(testScores, NUM_STDNTS, 4);
	wait();
	cout << endl << fixed << showpoint << setprecision(2) << "Average for Test #" << 8 << " is: " << averageOneTest(testScores, NUM_STDNTS, 7);
	wait();
	cout << endl << fixed << showpoint << setprecision(2) << "Average for Student #" << 5 << " is: " << averageOneStudent(testScores, NUM_STDNTS, 4);
	wait(); 
	cout << endl << fixed << showpoint << setprecision(2) << "Average for Student #" << 9 << " is: " << averageOneStudent(testScores, NUM_STDNTS, 8);
	wait();
	cout << endl << "Highest test score for Student #" << 2 << " is: " << highestOneStudent(testScores, NUM_STDNTS, 1);
	wait(); 
	cout << endl << "The top Student: " << topStudent(testScores, NUM_STDNTS) + 1;
	wait(); 
	return 0;
}
// Reads from file "Assignment1Data.txt"
void readTestScores(ifstream& file, int scores[][NUM_TESTS], int numStds)
{
	for (int i = 0; i < NUM_STDNTS; ++i)
	{
		for (int j = 0; j < NUM_TESTS; ++j)
		{
			file >> scores[i][j];
		}
	}
}
// Displays test scores in array.
void displayTestScores(int scores[][NUM_TESTS], int numStds)
{
	cout << "All Test Scores:\n";
	for (int i = 0; i < numStds; ++i)
	{
		for (int j = 0; j < NUM_TESTS; ++j)
		{
			cout << scores[i][j] << "   ";
		}
		cout << endl;
	}
	wait();
}
//Returns the total for tests specified in argument.
int totalOneTest(const int scores[][NUM_TESTS], int numStds, int testNumber)
{
	int total = 0;
	for (int i = 0; i < numStds; ++i)
	{
		total += scores[i][testNumber];
	}
	return total;
}
//Returns the total for students specified in argument.
int totalOneStudent(const int scores[][NUM_TESTS], int numStds, int studentNumber)
{
	int total = 0;
	for (int i = 0; i < NUM_TESTS; ++i)
	{
		total += scores[studentNumber][i];
	}
	return total;
}
//Returns the average for tests specified in argument.
double averageOneTest(const int scores[][NUM_TESTS], int numStds, int testNumber)
{
	return (totalOneTest(testScores, NUM_STDNTS, testNumber)*1.00) / numStds;
}
//Returns the average for students specified in argument.
double averageOneStudent(const int scores[][NUM_TESTS], int numStds, int studentNumber)
{
	return (totalOneStudent(testScores, NUM_STDNTS, studentNumber)*1.00) / NUM_TESTS;
}
//Returns Highest score for student specified in argument.
int highestOneStudent(const int scores[][NUM_TESTS], int numStds, int studentNumber)
{
	int highest = scores[studentNumber][0];
	for (int i = 0; i < NUM_TESTS; ++i)
	{
		if (highest < scores[studentNumber][i])
		{
			highest = scores[studentNumber][i];
		}
	}
	return highest;
}
// returns the student with the highest average test score.
int topStudent(const int scores[][NUM_TESTS], int numStds)
{
	double average;
	double highest = averageOneStudent(testScores, NUM_STDNTS, 0);
	int highest_student = 0;
	for (int i = 0; i < numStds; ++i)
	{
		average = averageOneStudent(testScores, NUM_STDNTS, i);
		if (highest < average)
		{
			highest = average;
			highest_student = i;
		}
	}
	return highest_student;
}
//Prompts user to "Press Enter to Continue" and waits.
void wait()
{
	cout << endl << "Press Enter to Continue";
	cin.get();
}