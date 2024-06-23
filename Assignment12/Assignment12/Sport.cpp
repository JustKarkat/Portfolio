#include "Sport.h"
#include <iostream>
using namespace std;

// Member Functions

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
}
void Sport::display() const
{
	if (!getName().empty())
	{
		cout << endl;
		cout << "Name: " << getName() << endl;
		cout << "Date: " << getDate().day << "/" << getDate().month << "/" << getDate().year << endl;
		cout << "Teams: " << getTeams() << endl;
		cout << "Lowest char in name: " << getLowest() << endl;
	}
	else
	{
		cout << "\nThere is nothing to display!\n";
	}
}
