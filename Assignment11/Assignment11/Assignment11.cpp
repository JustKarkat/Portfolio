//*********************************************************************** 
 //																		*
 //		Assignment:		#11												*
 //																		*
 //		File:			Assignment11.cpp								*
 //																		*
 //		Due Date:		17 April 2020									*
 //																		*
 //		Author:			Joshua Russell						          	*
 //																		*
 //		Course Name:	Programming II								    *
 //																		*
 //		Course Number:	COSC 1550										*
 //																		*
 //		Description:	Uses a class to manage info about a sport.		*
 //																		*
 //                                                                     *
 //     Other Necessary Files: N/A	   			                        *
 //																		*
 //***********************************************************************

#include <iostream>
#include <string>
#include <iomanip>
using namespace std;

// Global Constants

const int NUM_SPORTS = 3;

// Structures

struct Date
{
	int day;
	int month;
	int year;
};

//Class

class Sport
{
	private:
		string name;
		Date day_scheduled;
		int teams;
	public:
		string getName() const;
		void setName(const string);
		Date getDate() const;
		void setDate(const Date);
		int getTeams() const;
		void setTeams(const int);
		void populate();
		void display() const;
};

//Class Const Member Functions

string Sport::getName() const
{
	return name;
}

Date Sport::getDate() const
{
	return day_scheduled;
}

int Sport::getTeams() const
{
	return teams;
}

//Class Modifier Member Functions

void Sport::setName(const string n)
{
	name = n;
}
void Sport::setDate(const Date d)
{
	day_scheduled = d;
}
void Sport::setTeams(const int t)
{
	if (t < 0)
	{
		teams = 0;
	}
	else
	{
		teams = t;
	}
}

// Populate and Display

void Sport::populate()
{
	string n;
	Date d;
	int t;
	char slash;

	cin.ignore(1000, '\n');
	cout << "Name of Sport: ";
	getline(cin, n);
	setName(n);
	cout << "Date of Sport (DD/MM/YYYY): ";
	cin >> d.day >> slash >> d.month >> slash >> d.year;
	setDate(d);
	cout << "Number of Teams: ";
	cin >> t;
	setTeams(t);
}
void Sport::display() const
{
	if (!getName().empty())
	{
		cout << endl;
		cout << "Name: " << getName() << endl;
		cout << "Date: " << getDate().day << "/" << getDate().month << "/" << getDate().year << endl;
		cout << "Teams: " << getTeams() << endl;
	}
	else
	{
		cout << "\nThere is nothing to display!\n";
	}
}

// Function Definitions

bool sportOperations(int, Sport[NUM_SPORTS]);


int main()
{
	Sport sports[NUM_SPORTS];
	bool running = true;
	while (running)
	{
		running = sportOperations(NUM_SPORTS, sports);
	}
		

	return 0;
}

//Offers sport operations to user
bool sportOperations(int numSports, Sport s[NUM_SPORTS])
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
			s[sportChosen-1].populate();
			break;
		case 'D':
			cout << "What sport would you like to view (1-" << numSports << "): ";
			cin >> sportChosen;
			while (sportChosen < 1 || sportChosen > numSports)
			{
				cout << "Invalid sport option (1-" << numSports << ")" << ": ";
				cin >> sportChosen;
			}
			s[sportChosen-1].display();
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
			cout << "1) Name, 2) Date of next scheduled game, 3) Number of Teams?\n";
			cout << "Input: ";
			cin >> memberChosen;
			while (memberChosen < 1 || memberChosen > 3)
			{
				cout << "Invalid member option (1-3): ";
				cin >> memberChosen;
			}
			if (memberChosen == 1)
			{
				cout << "Name: " << s[sportChosen-1].getName() << endl;
			}
			if (memberChosen == 2)
			{
				cout << "Date: " << s[sportChosen-1].getDate().day << "/" << s[sportChosen-1].getDate().month << "/" << s[sportChosen-1].getDate().year << endl;
			}
			if (memberChosen == 3)
			{
				cout << "Teams: " << s[sportChosen-1].getTeams() << endl;
			}
			break;
		case 'F':
			for (int i = 0; i < numSports; ++i)
			{

				total += s[i].getTeams();

			}
			cout << fixed << showpoint << setprecision(2) << "Average number of Teams: " << static_cast<double>(total) / numSports << endl;
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