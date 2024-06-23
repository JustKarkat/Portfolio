//*********************************************************************** 
 //																		*
 //		Assignment:		#13												*
 //																		*
 //		File:			SportMain.cpp									*
 //																		*
 //		Due Date:		1 May 2020										*
 //																		*
 //		Author:			Joshua Russell						          	*
 //																		*
 //		Course Name:	Programming II								    *
 //																		*
 //		Course Number:	COSC 1550										*
 //																		*
 //		Description:	Edits made to Assignment 12 and the class.		*
 //																		*
 //                                                                     *
 //     Other Necessary Files:     N/A					                *
 //																		*
 //***********************************************************************


#include <iostream>
#include <string>
#include <iomanip>
#include "Sport.h"
using namespace std;


// Function Definitions

bool sportOperations(int, Sport*);
void averageAllSports(int, Sport*);


int main()
{
	int numSports;
	Sport* sports = nullptr;
	cout << "How many sports would you like to enter?" << endl;
	cout << "Input: ";
	cin >> numSports;
	sports = new Sport[numSports];

	bool running = true;
	while (running)
	{
		running = sportOperations(numSports, sports);
	}

	Sport* curr = nullptr;

	cout << "Here are all of the sports." << endl;

	for (int i = 0; i < numSports; ++i)
	{
		curr = &sports[i];

		cout << "Name: " << curr->getName() << endl;
		cout << "Date: " << curr->getDate().day << "/" << curr->getDate().month << "/" << curr->getDate().year << endl;
		cout << "Teams: " << curr->getTeams() << endl;
		for (int i = 0; i < curr->getTeams(); ++i)
		{
			cout << "Team " << i + 1 << " Name: " << curr->getTeam_Names()[i] << endl;
		}
	}

	delete[] sports;
	return 0;
}

//Offers sport operations to user
bool sportOperations(int numSports, Sport* s)
{
	int total = 0;
	int nearest = 0;
	char input;
	int sportChosen;
	int memberChosen;
	cout << "You have " << numSports << " Sports currently.\n";
	cout << "-------------------------------------------\n";
	cout << "A) Populate all sports in the Array,\n";
	cout << "B) Display all sports in the Array.\n";
	cout << "C) Populate a user chosen Sport.\n";
	cout << "D) Dispay a user chosen Sport.\n";
	cout << "E) Display info about a chosen Sport.\n";
	cout << "F) Display average number of teams for all Sports.\n";
	cout << "G) Display the next upcoming Sport.\n";
	cout << "H) Exit.\n";
	cout << "-------------------------------------------\n";
	cout << "What would you like to do?\n";
	cout << "Input: ";
	cin >> input;

	input = toupper(input);

	while (input < 'A' || input > 'H')
	{
		cout << "Please choose an option \'A\' to \'G\': ";
		cin >> input;
	}
	switch (input)
	{
	case 'A':
		for (int i = 0; i < numSports; ++i)
		{
			s[i].populate();
		}
		break;
	case 'B':
		if (!s[0].getName().empty())
		{
			for (int i = 0; i < numSports; ++i)
			{
				s[i].display();
			}
		}
		else
		{
			cout << "\nPlease populate sports before attempting to display...\n";
		}
		break;
	case 'C':
		cout << "What sport would you like to populate (1-" << numSports << "): ";
		cin >> sportChosen;
		while (sportChosen < 1 || sportChosen > numSports)
		{
			cout << "Invalid sport option (1-" << numSports << ")" << ": ";
			cin >> sportChosen;
		}
		s[sportChosen - 1].populate();
		break;
	case 'D':
		cout << "What sport would you like to view (1-" << numSports << "): ";
		cin >> sportChosen;
		while (sportChosen < 1 || sportChosen > numSports)
		{
			cout << "Invalid sport option (1-" << numSports << ")" << ": ";
			cin >> sportChosen;
		}
		s[sportChosen - 1].display();
		break;
	case 'E':
		cout << "What sport would you like to view (1-" << numSports << "): ";
		cin >> sportChosen;
		while (sportChosen < 1 || sportChosen > numSports)
		{
			cout << "Invalid sport option (1-" << numSports << ")" << ": ";
			cin >> sportChosen;
		}
		cout << "Which member would you like to view?\n";
		cout << "1) Name, 2) Date of next scheduled game, 3) Number of Teams, 4) Team Names?\n";
		cout << "Input: ";
		cin >> memberChosen;
		while (memberChosen < 1 || memberChosen > 4)
		{
			cout << "Invalid member option (1-4): ";
			cin >> memberChosen;
		}
		if (memberChosen == 1)
		{
			cout << "Name: " << s[sportChosen - 1].getName() << endl;
		}
		if (memberChosen == 2)
		{
			cout << "Date: " << s[sportChosen - 1].getDate().day << "/" << s[sportChosen - 1].getDate().month << "/" << s[sportChosen - 1].getDate().year << endl;
		}
		if (memberChosen == 3)
		{
			cout << "Teams: " << s[sportChosen - 1].getTeams() << endl;
		}
		if (memberChosen == 4)
		{
			for (int i = 0; i < s[sportChosen - 1].getTeams(); ++i)
			{
				cout << "Team " << i + 1 << " Name: " << s[sportChosen - 1].getTeam_Names()[i] << endl;
			}
		}
		break;
	case 'F':
		averageAllSports(numSports, s);
		break;
	case 'G':
		for (int i = 1; i < numSports; ++i)
		{
			if (s[i].getDate().year < s[nearest].getDate().year)
			{
				nearest = i;
			}
			else if (s[i].getDate().year == s[nearest].getDate().year)
			{
				if (s[i].getDate().month < s[nearest].getDate().month)
				{
					nearest = i;
				}
				else if (s[i].getDate().month == s[nearest].getDate().month)
				{
					if (s[i].getDate().day < s[nearest].getDate().day)
					{
						nearest = i;
					}
					else if (s[i].getDate().day == s[nearest].getDate().day)
					{
						cout << "\nMultiple sports have the same date.";
						break;
					}
				}
			}
		}
		cout << "Here is info about the next upcoming event.";
		s[nearest].display();
		break;
	case 'H':
	{
		cout << "\nExiting...\n";
		return false;
	}
	}
	cout << "---------------------\n";
	cout << "Press Enter to Continue...";
	cin.ignore();
	cin.get();
	system("CLS");
	return true;
}


//Give Average for all sports in array
void averageAllSports(int numSports, Sport* s)
{
	int total = 0;
	for (int i = 0; i < numSports; ++i)
	{

		total += s[i].getTeams();

	}
	cout << fixed << showpoint << setprecision(2) << "Average number of Teams: " << static_cast<double>(total) / numSports << endl;

}