//*********************************************************************** 
 //																		*
 //		Assignment:		#16												*
 //																		*
 //		File:			Assignment 16.cpp								*
 //																		*
 //		Due Date:		November 8										*
 //																		*
 //		Author:			Joshua Russell						        	*
 //																		*
 //		Course Name:	Programming I									*
 //																		*
 //		Course Number:	COSC 1550										*
 //																		*
 //		Description:	Calculates Occupancy rate for a hotel.	        *
 //																		*
 //																		*
 //***********************************************************************

#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
	int floors;

	int totalOccupied = 0,
		currentRooms,
		currentOccupied,
		totalRooms = 0;

	double occupancyRate;

	cout << "How many floors does the hotel have (must be positive): " << fixed << showpoint << setprecision(2);
	cin >> floors;
	while (floors <= 0)
	{
		cout << "Floors must be greater than 0, reenter: ";
		cin >> floors;
	}

	for (int i = 1; i <= floors; i++)
	{
		cout << "How many rooms are on floor " << i << ": ";
		cin >> currentRooms;

		while (currentRooms < 0)
		{
			cout << "Rooms must be greater than 0, reenter: ";
			cin >> currentRooms;
		}

		totalRooms += currentRooms;

		cout << "How many rooms are occupied on floor " << i << ": ";
		cin >> currentOccupied;

		while (currentOccupied < 0 || currentOccupied > currentRooms)
		{
			cout << "Occupied Rooms must be greater than 0 and less than rooms, reenter: ";
			cin >> currentOccupied;
		}

		totalOccupied += currentOccupied;
	}
	occupancyRate = static_cast<double>(totalOccupied) / totalRooms * 100.00;
	cout << "The hotel has a total of " << totalRooms << " rooms\n";
	cout << totalOccupied << " are occupied\n" << totalRooms - totalOccupied << " are unoccupied\n";
	cout << "The occupancy rate is " << occupancyRate << "% \n";
}

/*
OUTPUT:
How many floors does the hotel have (must be positive): 5
How many rooms are on floor 1: 4
How many rooms are occupied on floor 1: 3
How many rooms are on floor 2: 2
How many rooms are occupied on floor 2: 5
Occupied Rooms must be greater than 0 and less than rooms, reenter: -5
Occupied Rooms must be greater than 0 and less than rooms, reenter: 2
How many rooms are on floor 3: 5
How many rooms are occupied on floor 3: 10
Occupied Rooms must be greater than 0 and less than rooms, reenter: 5
How many rooms are on floor 4: -50
Rooms must be greater than 0, reenter: 2
How many rooms are occupied on floor 4: 1
How many rooms are on floor 5: 1
How many rooms are occupied on floor 5: 1
The hotel has a total of 14 rooms
12 are occupied
2 are unoccupied
The occupancy rate is 85.71%

*/