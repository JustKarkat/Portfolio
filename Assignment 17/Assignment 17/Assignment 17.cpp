//*********************************************************************** 
 //																		*
 //		Assignment:		#17												*
 //																		*
 //		File:			Assignment 17.cpp								*
 //																		*
 //		Due Date:		November 8										*
 //																		*
 //		Author:			Joshua Russell							        *
 //																		*
 //		Course Name:	Programming I									*
 //																		*
 //		Course Number:	COSC 1550										*
 //																		*
 //		Description:	Generates a random number and lets user guess.	*
 //																		*
 //																		*
 //***********************************************************************

#include <iostream>
#include <iomanip>
#include <random>
#include <ctime>
using namespace std;

int main()
{
	int guesses = 1;

	srand(time(0));

	int randNumber = rand() % 100 + 1;

	int userInput;

	cout << "What is your first guess?: ";
	cin >> userInput;

	while (userInput != randNumber)
	{
		if (userInput > randNumber)
		{
			cout << "Too High. What is your guess?: ";
			cin >> userInput;
			guesses++;
		}
		if (userInput < randNumber)
		{
			cout << "Too Low. What is your guess?: ";
			cin >> userInput;
			guesses++;
		}
	}

	cout << "You guessed correctly after " << guesses << " guesses!\n";


}

/*
OUTPUT:
What is your first guess?: 45
Too High. What is your guess?: 30
Too High. What is your guess?: 20
Too High. What is your guess?: 10
Too High. What is your guess?: 1
Too Low. What is your guess?: 2
Too Low. What is your guess?: 3
Too Low. What is your guess?: 4
Too Low. What is your guess?: 5
Too Low. What is your guess?: 6
You guessed correctly after 10 guesses!

*/