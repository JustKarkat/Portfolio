//*********************************************************************** 
 //																		*
 //		Assignment:		#X												*
 //																		*
 //		File:			AssignmentX.cpp								    *
 //																		*
 //		Due Date:		XX XX 2020									*
 //																		*
 //		Author:			Joshua Russell						          	*
 //																		*
 //		Course Name:	Programming II								    *
 //																		*
 //		Course Number:	COSC 1550										*
 //																		*
 //		Description:			*
 //												*
 //                                                                     *
 //     Other Necessary Files:                      *
 //																		*
 //***********************************************************************

#include <iostream>
#include <iomanip>
#include <string>
#include <fstream>
using namespace std;
//Prototypes
struct Date

{

	int day;

	int month;

	int year;

};

struct Exam

{

	char name[30];

	Date dateScheduled;

	int numStudents;

};



int main()
{
	fstream f; 
	f.open("test.dat", ios::in|ios::binary);
	fstream fo; 
	fo.open("test.dat", ios::out|ios::binary);
	
	Exam testing;
	strcpy_s(testing.name, "Jackson");
	testing.dateScheduled.day = 11;
	testing.dateScheduled.month = 4;
	testing.dateScheduled.year = 2001;

	testing.numStudents = 2;


	fo.write(reinterpret_cast<char*>(&testing), sizeof(Exam));

	fo.close();

	if (fo.fail())
	{
		cout << "fail";
	}

	Exam test1;
	
	f.read(reinterpret_cast<char*>(&test1), sizeof(Exam));

	cout << test1.name << endl << test1.numStudents << endl << test1.dateScheduled.day << endl << test1.dateScheduled.month << endl << test1.dateScheduled.year;
	
	f.close();

	return 0;
}