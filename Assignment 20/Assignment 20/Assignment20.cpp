//*********************************************************************** 
 //																		*
 //		Assignment:		#20												*
 //																		*
 //		File:			Assignment20.cpp								*
 //																		*
 //		Due Date:		December 9th 2019						    	*
 //																		*
 //		Author:			Joshua Russell						        	*
 //																		*
 //		Course Name:	Programming I									*
 //																		*
 //		Course Number:	COSC 1550										*
 //																		*
 //		Description:	Works on one student's test scores.	            *
 //																		*
 //																		*
 //***********************************************************************

#include <iostream>
#include <iomanip>
using namespace std;

//Global Variables

const int TESTS = 4;

//Prototypes

void getTests(double[TESTS]);
double toTotalTests(double[TESTS]);
double getAverage(double);
double getHighest(double[TESTS]);
double getLowest(double[TESTS]);
void report(double, double, double, double);

void wait();

int main()
{
	double testScores[TESTS],
		   total;

	getTests(testScores);

	total = toTotalTests(testScores);

	report(total, getAverage(total), getHighest(testScores), getLowest(testScores));

}
//***********************************************************************
// Gets test scores and passes them to testScores array.
void getTests(double testScores[TESTS])
{
	for (int count = 0; count < TESTS; count++)
	{
		cout << "Enter test score " << count + 1 << ": ";
		cin >> testScores[count];
		while (testScores[count] > 100 || testScores[count] < 0)
		{
			cout << "\nMust be within 0-100 for scores.\nPlease Enter test score " << count + 1 << ": ";
			cin >> testScores[count];
		}
	}
	wait();
}
//***********************************************************************
// Gets the total of all test scores.
double toTotalTests(double testScores[TESTS])
{
	double total = 0;
	for (int count = 0; count < TESTS; count++)
	{
		total += testScores[count];
	}
	wait();
	return total;
}

//***********************************************************************
// Gets average of test scores.
double getAverage(double total)
{
	double Average = total / TESTS;
	wait();
	return Average;
}

//***********************************************************************
// Gets highest of all test scores.
double getHighest(double testScores[TESTS])
{
	double highest = testScores[0];
	for (int count = 0; count < TESTS; count++)
	{
		if (highest <= testScores[count])
		{
			highest = testScores[count];
		}
	}
	wait();
	return highest;
}
//***********************************************************************
// Gets lowest of all test scores.
double getLowest(double testScores[TESTS])
{
	double lowest = testScores[0];
	for (int count = 0; count < TESTS; count++)
	{
		if (lowest >= testScores[count])
		{
			lowest = testScores[count];
		}
	}
	wait();
	return lowest;
}
//***********************************************************************

//***********************************************************************
// Reports all data about test scores.
void report(double total, double average, double highest, double lowest)
{
	cout << "The total score is: " << total << endl;
	cout << "The total average of the scores is: " << average << endl;
	cout << "The highest score is: " << highest << endl;
	cout << "The lowest score is: " << lowest << endl;
}

//***********************************************************************
// Asks user to press enter to continue and waits for input.
void wait()
{
	cout << "Press Enter to Continue...";
	cin.ignore();
	cin.get();
}

/*
OUTPUT: 
Set 1:
Enter test score 1: 1
Enter test score 2: 2
Enter test score 3: 3
Enter test score 4: 4
Press Enter to Continue...
Press Enter to Continue...
Press Enter to Continue...
Press Enter to Continue...
Press Enter to Continue...
The total score is: 10
The total average of the scores is: 2.5 
The highest score is: 4 
The lowest score is: 1

/// 
Hand Math Checks Out.  1 + 2 + 3 + 4 = 10, 10 / 4 = 2.5, 4 > rest, 1 < rest. 
///

Set 2: 
Enter test score 1: 10 
Enter test score 2: 9
Enter test score 3: 8 
Enter test score 4: 7 
Press Enter to Continue... 
Press Enter to Continue...
Press Enter to Continue...
Press Enter to Continue...
Press Enter to Continue...
The total score is: 34 
The total average of the scores is: 8.5 
The highest score is: 10 
The lowest score is: 7
// 
Hand Math Checks Out. 10 + 9 + 8 + 7 = 34, 34 / 4 = 8.5, 10 > rest, 7 < rest. 
//

SET 3:
Enter test score 1: 100.2

Must be within 0-100 for scores.
Please Enter test score 1: 100.00
Enter test score 2: 12.20
Enter test score 3: 0.02
Enter test score 4: 21.2
Press Enter to Continue...
Press Enter to Continue...

Press Enter to Continue...

Press Enter to Continue...

Press Enter to Continue...

The total score is: 133.42
The total average of the scores is: 33.355
The highest score is: 100
The lowest score is: 0.02
*/