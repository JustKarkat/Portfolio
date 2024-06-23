//*********************************************************************** 
 //																		*
 //		Assignment:		#8												*
 //																		*
 //		File:			Assignment8.cpp								    *
 //																		*
 //		Due Date:		March 27 2020									*
 //																		*
 //		Author:			Joshua Russell						          	*
 //																		*
 //		Course Name:	Programming II								    *
 //																		*
 //		Course Number:	COSC 1550										*
 //																		*
 //		Description:	Pulls data and stores data in an employee		*
 //						file using nested structs						*
 //                                                                     *
 //     Other Necessary Files:  Employees.txt		                    *
 //																		*
 //***********************************************************************

#include <iostream>
#include <string>
#include <fstream>
#include <iomanip>
using namespace std;

//Structures

struct Date {

	int day;
	int month;
	int year;

};

struct Employee {

	string name;
	int age;
	Date date;

};


//Prototypes
Employee* readEmployees(const string&, int&);
void displayEmployees(const Employee[], int);
Employee* inputEmployees(Employee*, int&);


int main()
{
	int numEmployees;
	Employee *list = readEmployees("Employees.txt", numEmployees);
	displayEmployees(list, numEmployees);

	char answer;
	cout << "Do you want to input more Employees? (Y/N): ";
	cin >> answer;
	answer = toupper(answer);
	if (answer != 'Y' && answer != 'N')
	{
		cout << "Please enter \'Y/N\': ";
		cin >> answer;
	}
	if (toupper(answer) == 'Y')
	{ 
		list = inputEmployees(list, numEmployees);
		displayEmployees(list, numEmployees);
		fstream file("Employees.txt", ios::out);
		file << numEmployees;
		file << '\n';
		for (int i = 0; i < numEmployees; ++i)
		{
			file << list[i].name;
			file << ",";
			file << list[i].age;
			file << ",";
			file << list[i].date.day;
			file << "/";
			file << list[i].date.month;
			file << "/";
			file << list[i].date.year;
			file << "\n";
		}
		file.close();
	}
	delete[] list;
	return 0;
}
//Reads Employees
Employee* readEmployees(const string& empFile, int& numEmps)
{
	fstream file(empFile, ios::in);
	if (!file)
	{
		cout << "Failed to read file";
		return 0;
	}
	Employee *list = nullptr;

	file >> numEmps;
	file.get();

	list = new Employee[numEmps];

	for (int i = 0; i < numEmps; ++i)
	{
		getline(file, list[i].name, ',');
		file >> list[i].age;
		file.get();
		file >> list[i].date.day;
		file.get();
		file >> list[i].date.month;
		file.get();
		file >> list[i].date.year;
		file.get();
	}
	file.close();
	return list;
}
//Displays Employees
void displayEmployees(const Employee list[], int numEmps)
{
	cout << left << setw(32) << "NAME" << setw(24) << "AGE" << "DATE EMPLOYED" << endl;
	string date;
	for (int i = 0; i < numEmps; ++i)
	{
		date = to_string(list[i].date.day) + "/" + to_string(list[i].date.month) + "/" + to_string(list[i].date.year);
		cout << left << setw(32) << list[i].name << setw(24) << list[i].age << date << endl;
	}
}
//gets employees for input
Employee* inputEmployees(Employee* list, int& numEmps)
{
	Employee* newList = nullptr;
	int numToAdd;
	int previous_num = numEmps;
	cout << "How many employees would you like to add: ";
	cin >> numToAdd;
	numEmps += numToAdd;

	newList = new Employee[numEmps];

	for (int i = 0; i < previous_num; ++i)
	{
		newList[i].name = list[i].name;
		newList[i].age = list[i].age;
		newList[i].date = list[i].date;
	}
	for (int i = previous_num; i < numEmps; ++i)
	{
		char slash;
		cout << "Name: ";
		cin.ignore(1000, '\n');
		getline(cin, newList[i].name);
		cout << "Age: ";
		cin >> newList[i].age;
		cin.ignore(1000, '\n');
		cout << "Employed (DD/MM/YY): ";
		cin >> newList[i].date.day >> slash >> newList[i].date.month >> slash >> newList[i].date.year;
	}
	return newList;
}