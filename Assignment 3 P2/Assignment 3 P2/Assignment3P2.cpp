//*********************************************************************** 
 //																		*
 //		Assignment:		#3												*
 //																		*
 //		File:			Assignment3P2.cpp							    *
 //																		*
 //		Due Date:		7 February 2020									*
 //																		*
 //		Author:			Joshua Russell						          	*
 //																		*
 //		Course Name:	Programming II								    *
 //																		*
 //		Course Number:	COSC 1550										*
 //																		*
 //		Description:	Uses Pointers to Integers to do math.   		*
 //									                         			*
 //                                                                     *
 //     Other Necessary Files: N/A                                      *
 //																		*
 //***********************************************************************

#include <iostream>
using namespace std;

int main()
{
	int n1 = 10,
		n2 = 25,
		n3 = 50;
	int* p1 = &n1;
	int* p2 = &n2;
	*p1 = 2 * *p1;
	cout << *p1 + *p2 << endl;
	p1 = &n3;
	cout << *p1 + *p2 << endl;
	return 0;
}