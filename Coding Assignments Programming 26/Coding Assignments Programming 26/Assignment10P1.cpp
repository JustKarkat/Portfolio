//*********************************************************************** 
 //																		*
 //		Assignment:		#10 P1											*
 //																		*
 //		File:			Assignment10P1.cpp							    *
 //																		*
 //		Due Date:		10 April 2020									*
 //																		*
 //		Author:			Joshua Russell						          	*
 //																		*
 //		Course Name:	Programming II								    *
 //																		*
 //		Course Number:	COSC 1550										*
 //																		*
 //		Description:	Part of program that teaches translation		*
 //						from American Eng. --> 'Proper' Eng. using a	*
 //						binary file. This simply converts the .txt -.dat*                                                                   
 //																		*
 //     Other Necessary Files:    'Testers.dat' & 'Translations.txt'    *
 //																		*
 //***********************************************************************

#include <iostream>
#include <iostream>
#include <string>
#include <iomanip>
#include <fstream>
using namespace std;

//Structures
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


int main()
{

	fstream text("Testers.txt", ios::in);
	fstream binary("Testers.dat", ios::out | ios::binary);
	if (binary.fail() || text.fail())
	{
		cout << "Failed to convert due to missing file.";
		return 0;
	}
	else
	{
		cout << "Successfully converted the \"Testers.txt\" to binary file..." << endl;
	}
	int perlength;

	text >> perlength;
	//cout << perlength << endl;
	text.get();
	
	Person* list = new Person[perlength];

	for (int i = 0; i < perlength; ++i)
	{
		text.getline(list[i].name, 20);
		text >> list[i].score;
		text.get();
		text >> list[i].testTaken.day;
		text.get();
		text >> list[i].testTaken.month;
		text.get();
		text >> list[i].testTaken.year;
		text.get();
	}
	text.close();
	binary.write(reinterpret_cast<char*>(&perlength), sizeof(int));
	binary.write(reinterpret_cast<char*>(list), sizeof(Person)*perlength);
	binary.close();
	delete[] list;

	/* old code used for testing purposes
	binary.open("Testers.dat", ios::in | ios::binary);

	Person ptest;
	int test;
	long int randTest[3];
	binary.read(reinterpret_cast<char*>(&test), sizeof(int));
	cout << test<< endl;
	binary.seekg(sizeof(int) + (sizeof(Person) * randTest[]), ios::beg);
	binary.read(reinterpret_cast<char*>(&ptest), sizeof(Person));
	cout << ptest.name << endl;
	binary.close();	*/
	
	return 0;

}
