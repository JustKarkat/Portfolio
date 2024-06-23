//*********************************************************************** 
 //																		*
 //		Assignment:		#10 P2											*
 //																		*
 //		File:			Assignment10P2.cpp								*
 //																		*
 //		Due Date:		10 April 2020									*
 //																		*
 //		Author:			Joshua Russell						          	*
 //																		*
 //		Course Name:	Programming II								    *
 //																		*
 //		Course Number:	COSC 1550										*
 //																		*
 //		Description:	Enables students to learn how to translate from *
 //						American English to "proper" English using		*
 //                     binary files.                                   *
 //     Other Necessary Files:   Translation.txt, Testers.dat           *
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
void takeTest(const Translation[], int, Person&);
void testersUpdates(const Translation t[], int numT, const string& fileName);
void displayTesters(const string& fileName);

int main()
{
	int numT;
	string testersFilename = "Testers.dat";
	string translationsFilename = "Translation.txt";

	Translation* translations = readTranslation(translationsFilename, numT);

	testersUpdates(translations, numT, testersFilename);
	displayTesters(testersFilename);

	delete[] translations;
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
// Updates the testers.dat file
void testersUpdates(const Translation t[], int numT, const string& fileName)
{
	int numP;
	fstream testers(fileName, ios::in| ios::out | ios::binary);
	Person temp;
	testers.read(reinterpret_cast<char*>(&numP), sizeof(int));
	char slash;
	Date currDate;
	long int randTest[3];

	cout << "Please enter the current date (DD/MM/YY): ";
	cin >> currDate.day >> slash >> currDate.month >> slash >> currDate.year;
	srand(time(0) + currDate.year + currDate.day);
	for (int i = 0; i < 3; ++i)
	{
		randTest[i] = rand() % numP;
		testers.seekg(sizeof(int) + (sizeof(Person)*randTest[i]), ios::beg);
		testers.read(reinterpret_cast<char*>(&temp), sizeof(Person));
		takeTest(t, numT, temp);
		temp.testTaken = currDate;
		testers.seekp(sizeof(int) + (sizeof(Person)*randTest[i]), ios::beg);
		testers.write(reinterpret_cast<char*>(&temp), sizeof(Person));
	}
	testers.close();
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
void displayTesters(const string& fileName)
{
	fstream testers(fileName, ios::in | ios::binary);
	int numP;
	Person temp;
	testers.read(reinterpret_cast<char*>(&numP), sizeof(int));
	cout << left << setw(20) << "Name" << setw(20) << "Score" << setw(20) << "Date Taken" << endl;
	for (int i = 0; i < numP; ++i)
	{
		testers.read(reinterpret_cast<char*>(&temp), sizeof(Person));
		cout << left << setw(20) << temp.name << setw(20) << temp.score << temp.testTaken.day << "/" << temp.testTaken.month << "/" << temp.testTaken.year << endl;
	}
}