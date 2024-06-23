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
//Structures
struct Sport

{

	char name[25];

	int numPlayers;

	int numTournaments;

};
//Prototypes


int main()
{

	const int NUM_SPORTS = 20;

	int sports = NUM_SPORTS;
	fstream file("Sport.dat", ios::out | ios::binary);

	file.write(reinterpret_cast<char*>(&sports), sizeof(int));
	Sport events[NUM_SPORTS];
	for (int i = 0; i < NUM_SPORTS; ++i)
	{
		strcpy_s(events[i].name, sizeof(events[i].name), "name");
		cout << events[i].name << endl;
		events[i].numPlayers = rand();
		cout << events[i].numPlayers << endl;
		events[i].numTournaments = rand();
		cout << events[i].numTournaments << endl;
	}

	
	file.write(reinterpret_cast<char*>(events), sizeof(events));

	file.close();

	file.open("Sports.dat", ios::in | ios::binary);

	int numSports;

	file.read(reinterpret_cast<char*>(&numSports), sizeof(int));
	
	cout << "Output test: " << numSports << endl;
	
	file.close();

	return 0;
}
