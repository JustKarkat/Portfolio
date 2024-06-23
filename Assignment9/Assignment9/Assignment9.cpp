//*********************************************************************** 
 //																		*
 //		Assignment:		#9												*
 //																		*
 //		File:			Assignment9.cpp								    *
 //																		*
 //		Due Date:		3 April 2020									*
 //																		*
 //		Author:			Joshua Russell						          	*
 //																		*
 //		Course Name:	Programming II								    *
 //																		*
 //		Course Number:	COSC 1550										*
 //																		*
 //		Description:	Enables students to learn how to translate from *
 //						American English to "proper" English.			*
 //                                                                     *
 //     Other Necessary Files:   Translation.txt, Testers.txt           *
 //																		*
 //***********************************************************************

#include <iostream>
#include <string>
#include <iomanip>
#include <fstream>
#include <ctime>
using namespace std;

//Structures
struct Translation
{
	string american; // A word in American
	string english; // The equivalent (proper) word in English
};
struct Date
{
	int day;
	int month;
	int year;
};
struct Person
{
	char name[20];
	double score;
	Date testTaken;
};
//Prototypes
Translation* readTranslation(const string&, int&);
Person* readTesters(const string&, int&);
void testingOptions(const Translation[], int, Person[], int);
void takeTest(const Translation[], int, Person&);
void displayTesters(const Person[], int);
void writeTesters(const string&, const Person[], int);

int main()
{
	int numTranslations;
	int numTesters;
	string testersFilename = "Testers.txt";
	string translationsFilename = "Translation.txt";

	Translation* translations = readTranslation(translationsFilename, numTranslations);
	Person* testers = readTesters(testersFilename, numTesters);

	testingOptions(translations, numTranslations, testers, numTesters);

	displayTesters(testers, numTesters);
	writeTesters(testersFilename, testers, numTesters);

	delete[] translations;
	delete[] testers;
	return 0;
}
//Reads in the translations from the translations file.
Translation* readTranslation(const string& filename, int& num)
{
	Translation* translations = nullptr;
	fstream file(filename, ios::in);
	file >> num;
	file.get();
	translations = new Translation[num];
	for (int i = 0; i < num; ++i)
	{
		getline(file, translations[i].american, ',');
		getline(file, translations[i].english, '\n');
	}
	file.close();
	return translations;
}
//Reads the testers file.
Person* readTesters(const string& filename, int& num)
{
	Person* testers = nullptr;
	fstream file(filename, ios::in);
	file >> num;
	file.get();
	testers = new Person[num];
	for (int i = 0; i < num; ++i)
	{
		file.getline(testers[i].name, 20);
		file >> testers[i].score;
		file.get();
		file >> testers[i].testTaken.day;
		file.get();
		file >> testers[i].testTaken.month;
		file.get();
		file >> testers[i].testTaken.year;
		file.get();
	}
	file.close();
	return testers;
}
//Asks user to enter the current date, generates ranom numbers for each person.
void testingOptions(const Translation t[], int numT, Person people[], int numP)
{
	char slash;
	Date currDate;

	int randTest[3];

	cout << "Please enter the current date (DD/MM/YY): ";
	cin >> currDate.day >> slash >> currDate.month >> slash >> currDate.year;
	srand(time(0) + currDate.year + currDate.day);
	for (int i = 0; i < 3; ++i)
	{
		randTest[i] = rand() % numP;
		takeTest(t, numT, people[randTest[i]]);
		people[randTest[i]].testTaken = currDate;
	}
}
// Actually makes the test happen for each passed person and translations.
void takeTest(const Translation t[], int numT, Person& p)
{
	int numRight = 10;
	string answer;
	int randQ;
	cout << p.name << ": " << endl;
	cin.ignore(100, '\n');
	for (int i = 0; i < 10; ++i)
	{
		randQ = rand() % numT;
		cout << "Question " << i + 1 << ":" << endl;
		cout << "What is the \'proper\' English translation of \'" << t[randQ].american << "\': ";
		getline(cin, answer);
		if (answer == "")
		{
			cout << "Enter an answer: ";
			getline(cin, answer);
		}
		if (answer != t[randQ].english)
		{
			numRight -= 1;
		}
	}
	p.score = numRight * 10;
}
// Displays the current Testers array.
void displayTesters(const Person p[], int numP)
{
	cout << left << setw(20) << "Name" << setw(20) << "Score" << setw(20) << "Date Taken" << endl;
	for (int i = 0; i < numP; ++i)
	{
		cout << left << setw(20) << p[i].name << setw(20) << p[i].score << p[i].testTaken.day << "/" << p[i].testTaken.month << "/" << p[i].testTaken.year << endl;
	}
}
// Writes the testers array to the file.
void writeTesters(const string& filename, const Person p[], int numP)
{
	fstream file(filename, ios::out);
	file << numP << endl;
	for (int i = 0; i < numP; ++i)
	{
		file << p[i].name << endl;
		file << p[i].score << "," << p[i].testTaken.day << "/" << p[i].testTaken.month << "/" << p[i].testTaken.year << endl;
	}
	file.close();
}