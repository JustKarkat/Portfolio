#include <iostream>
#include "Sport.h"
using namespace std;

//Constructor and Destructor

Sport::~Sport()
{
	delete[] team_names;
}

// Member Functions

char Sport::getLowest() const
{
	string name = getName();
	char lowest = name[0];
	for (int i = 1; i < name.length(); i++)
	{
		if (name[i] < lowest)
		{
			lowest = name[i];
		}
	}
	return lowest;
}

std::string* Sport::getTeam_Names() const
{
	return team_names;
}

//Modifier Functions

void Sport::setName(const string& n)
{
	name = n;
}
void Sport::setDate(const Date& d)
{
	if ((d.day <= 31 && d.day > 0) && (d.month <= 12 && d.month > 0))
	{
		day_scheduled = d;
	}
	else
	{
		day_scheduled.day = 1;
		day_scheduled.month = 1;
		day_scheduled.year = 2000;
	}
}
void Sport::setTeams(const int& t)
{
	if (t < 0)
	{
		teams = 5;
	}
	else
	{
		teams = t;
	}
}

void Sport::setTeam_Names(std::string* s)
{
	team_names = s;
}




// Popualate / Display Functions

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
	cout << "Names of Teams: " << endl;
	cin.ignore();
	std::string* temp = new string[t];
	for (int i = 0; i < t; ++i)
	{
		cout << "Team " << i + 1 << ": ";
		getline(cin, temp[i]);
	}
	setTeam_Names(temp);
	delete[] temp;
}
void Sport::display() const
{
	if (!getName().empty())
	{
		cout << endl;
		cout << "Name: " << getName() << endl;
		cout << "Date: " << getDate().day << "/" << getDate().month << "/" << getDate().year << endl;
		cout << "Teams: " << getTeams() << endl;
		cout << "Team Names: " << endl;
		for (int i = 0; i < getTeams(); ++i)
		{
			cout << i + 1 << ") " << getTeam_Names()[i] << endl;
		}
		cout << "Lowest char in name: " << getLowest() << endl;
	}
	else
	{
		cout << "\nThere is nothing to display!\n";
	}
}
