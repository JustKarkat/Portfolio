//*********************************************************************** 
 //																		*
 //		Assignment:		#4												*
 //																		*
 //		File:			Assignment4.cpp								    *
 //																		*
 //		Due Date:		14 February 2020								*
 //																		*
 //		Author:			Joshua Russell						          	*
 //																		*
 //		Course Name:	Programming II								    *
 //																		*
 //		Course Number:	COSC 1550										*
 //																		*
 //		Description:	Deals with pointers and arrays, with user		*
 //						prompts and differing outputs.					*
 //                                                                     *
 //     Other Necessary Files:    N/A   				                *
 //																		*
 //***********************************************************************

#include <iostream>
using namespace std;

const int SZ = 5;

//Prototypes
void inputThreeOutput(int[], const int);
void inputTwoAdd(int[], const int);

void showArray(const int[], const int);

int main()
{
	
	int numbers[SZ] = { 10, 22, 34, 48, 59 };
	int* pointer = numbers;
	inputThreeOutput(numbers, SZ);
	inputTwoAdd(numbers, SZ);

	return 0;
}
// Takes 3 integer inputs from User and prints info for each index given.
void inputThreeOutput(int numbers[], const int size)
{

	showArray(numbers, size);

	const int NUMINP = 3; //could be changed to allow any number of inputs.
	int input[NUMINP];
	int* numPointer = nullptr;
	cout << "Give " << NUMINP << " index locations for an array of size " << size << ".\n";
	for (int i = 0; i < NUMINP; ++i)
	{
		cout << "Input #" << i + 1 << "\n";
		do 
		{
			cout << "Must be within 1-" << size << ": ";
			cin >> input[i];
		} while ((input[i] < 1) || (input[i] > size));
		numPointer = &numbers[input[i] - 1];
		cout << "Index: " << input[i] << endl;
		cout << "Address: " << numPointer << endl;
		cout << "Value: " << *numPointer << endl << endl;
	}


}
// Takes 2 integer inputs from User and adds the values in the given index together.
void inputTwoAdd(int numbers[], const int size)
{
	showArray(numbers, size);
	int input[2];
	int* numPointer1 = nullptr;
	int* numPointer2 = nullptr;
	cout << "Input two index locations for an array of size " << size << ".\n";
	
	for (int i = 0; i < 2; ++i)
	{
		cout << "Input #" << i + 1 << "\n";
		do
		{
			cout << "Must be within 1-" << size << ": ";
			cin >> input[i];
		} while ((input[i] < 1) || (input[i] > size));
	}
	numPointer1 = &numbers[input[0] - 1];
	numPointer2 = &numbers[input[1] - 1];
	cout << "The values at these memory locations add to " << *numPointer1 + *numPointer2 << ".\n";;
}

//Outputs array for viewing.
void showArray(const int numbers[], const int size)
{
	cout << "(Format: \"Value @ Address\")\n";
	cout << "Array:\n";
	for (int i = 0; i < size - 1; ++i)
	{
		cout << numbers[i] << " @ " << &numbers[i] << ", \n";
	}
	cout << numbers[size - 1] << " @ " << &numbers[size - 1] << "\n";
}