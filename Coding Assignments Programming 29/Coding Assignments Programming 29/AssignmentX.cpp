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
#include <fstream>
#include <string>
using namespace std;

struct Person

{

	string firstName;

	string lastName;

};


struct Team
{

	string teamName;

	Person namesOfMembers[10];

};

void populate(Team);


int main()
{
	Team list[5];

	for (int i = 0; i < 5; ++i)
	{
		populate(list[i]);
	}


	return 0;
}

void populate(Team t)
{

	cout << "What is this teams name: ";
	getline(cin, t.teamName);

	for (int i = 0; i < 10; ++i)
	{
		cout << "What is member " << i + 1 << "\'s first name: ";
		cin >> t.namesOfMembers[i].firstName;
		cout << "What is member " << i + 1 << "\'s last name: ";
		cin >> t.namesOfMembers[i].lastName;
	}

	cin.ignore();

}