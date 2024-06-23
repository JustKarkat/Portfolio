//*********************************************************************** 
 //																		*
 //		Assingment:		#												*
 //																		*
 //		File:										*
 //																		*
 //		Due Date:												*
 //																		*
 //		Author:												*
 //																		*
 //		Course Name:										*
 //																		*
 //		Course Number:											*
 //																		*
 //		Description:	This program									*
 //																		*
 //																		*
 //***********************************************************************

#include <iostream>
#include <string>
#include <iomanip>
#include <vector>
#include <sstream>

using namespace std;

void Sender();
void calc();

const int MAX_LINES = 100;

int main()
{
	
	int c = 0;
	char choice;
	bool cont = true;
	while (cont)
	{
		do
		{
			cout << "Please choose if you are the sender or recever (S = Sender R = Receiver)" << endl;
			cin >> choice;
			switch (toupper(choice))
			{
			case 'S':
			{
				cout << "Sender" << endl;
				Sender();
				c = 1;
				break;
			}
			case 'R':
			{
				cout << "Receiver" << endl;
				calc();
				c = 1;
				break;
			}
			default:
			{
				system("CLS");
				cout << "Not a valid Choice Please choose again" << endl;

				break;
			}
			}
		} while (c == 0);

		cout << "Do you want to run this again? (Y/N)" << endl;
		char answ;
		cin >> answ;
		if (toupper(answ) == 'N')
		{
			cont = false;
		}
		cout << endl;
	}
	
}

void Sender()
{
	int result = 0;
	bool skip = true;
	int tempIndent = 0;
	int previndent = 0;
	int genBits = 4;
	int dataBits = 6;



	cout << "How many bits does the generator have?" << endl;
	 cin >> genBits;
	 cout << "How many bits does the data have?" << endl;
	 cin >> dataBits;
	 int* gen = new int[genBits];
	 int* data = new int[dataBits];
	 cout << "Please enter the generator seperated by spaces" << endl;
	 for (int i = 0; i < genBits; ++i)
	 {
		 cin >> gen[i];
	 }
	 cout << "Please enter the Data seperated by spaces" << endl;
	 for (int i = 0; i < dataBits; ++i)
	 {
		 cin >> data[i];
	 }
	 cout << endl;
	 
	int indent = genBits + 1;

	int array[100][100];

	for (int j = 0; j < genBits; j++)
	{
		array[j][0] = gen[j];
	}
	array[genBits][0] = -1;
	for (int j = 0; j < dataBits; j++)
	{
		array[j + genBits + 1][0] = data[j];
	}
	for (int j = 0; j < genBits - 1; j++)
	{
		array[j + genBits + dataBits + 1][0] = 0;
	}
	array[genBits + genBits + dataBits + 1][0] = -2;

	for (int k = 1; k < MAX_LINES; k++)
	{
		for (int i = 0; i < indent; i++)
		{
			array[i][k] = -1;
		}
		if (k < genBits + dataBits - 1)
		{
			for (int i = 0; i < genBits; i++)
			{

				array[i + indent][k] = gen[i];
				
			}
			array[indent + genBits][k] = -2;
			k++;
		}
		for (int i = 0; i <= indent; i++)
		{
			array[i][k] = -1;
		}
		skip = true;
		tempIndent = 0;
		for (int i = 0; i < genBits; i++)
		{
			array[i + indent][k] = array[i + indent][k - 2] ^ array[i + indent][k - 1];
			if (array[i + indent][k] == 0)
			{
				if (skip)
				{
					array[i + indent][k] = -1;
					tempIndent++;
				}

			}
			else if (array[i + indent][k] == 1)
			{
				skip = false;
			}

		}
		//cout << tempIndent << endl;
		int p = 0;
		int inc = 0;
		//cout << indent << endl;

		indent = indent + tempIndent;
		for (int i = 0; i < indent; i++)
		{
			if ((array[i + indent][k] < -2) && (inc < tempIndent))
			{
				inc++;
				array[i + indent][k] = array[i + indent][0];
				p = i;
			}
		}
		//cout << p << endl;
		array[p + indent + 1][k] = -2;
	}

	string output = "";
	string temp = "";
	int counter = 0;
	int indentcount = 0;
	string remainder;
	for (int i = 0; i < genBits - 1; i++)
	{
		remainder = remainder + '0';
	}
	for (int j = 0; j < 10; j++)
	{
		for (int i = 0; i < 100; i++)
		{
			if (array[i][j] == -2)
			{ 
				counter++;
				if ((j < (dataBits + genBits - 1)))
				{
					output = output + "\n";
				}
				
				if (!((counter) % 2 == 1) && !(array[i-1][j] < -800) && (array[i - 1][j] != -1) && (j < (dataBits + genBits - 1)))
				{
					for (int i = 0; i < indentcount; i++)
					{
						output = output + " ";
					}
					output = output + "----\n";
				}
				indentcount = 0;
				break;
			}
			
			else if ((array[i][j] == -1) && (j < (dataBits + genBits - 1)))
			{
				indentcount++;
				output = output + " ";
			}
			else if (j < (dataBits + genBits - 1) && (array[i][j] > -800))
			{
				temp = to_string(array[i][j]);
				output = output + temp;
			}
			
		}
	}
	for (int i = 0; i < output.length(); ++i)
	{
		if ((i > 1) && (output[output.length() - i] == '\n'))
		{
			break;
		}
		if (isdigit(output[output.length() - i]))
		{
			remainder[remainder.length() - i + 1] = output[output.length() - i];
		}
	}


	string sent_bits = "";
	string generator = "";
	string d = "";
	for (int i = 0; i < dataBits; i++)
	{
		d = d + to_string(data[i]);
	}
	for (int i = 0; i < genBits; i++)
	{
		generator = generator + to_string(gen[i]);
	}
	sent_bits = d + remainder;
	cout << output << endl;
	cout << "Summary" << endl;
	cout << "------------------------" << endl;
	cout << "generator: " << generator << endl;
	cout << "data: " << d << endl;
	cout << "remainder: " << remainder << endl;
	cout << "sent bits: " << sent_bits << endl;



}

void calc()
{

	int result = 0;
	bool skip = true;
	int tempIndent = 0;
	int previndent = 0;
	int genBits = 4;
	int sentBits = 6;
	


	cout << "How many bits does the generator have?" << endl;
	cin >> genBits;
	cout << "How many bits does the message have?" << endl;
	cin >> sentBits;
	int* gen = new int[genBits];
	int* send = new int[sentBits];

	cout << "Please enter the generator seperated by spaces" << endl;
	for (int i = 0; i < genBits; ++i)
	{
		cin >> gen[i];
	}
	cout << "Please enter message seperated by spaces" << endl;
	for (int i = 0; i < sentBits; ++i)
	{
		cin >> send[i];
	}
	
	cout << endl;

	int dataBits = sentBits - (genBits - 1);
	int* data = new int[dataBits];

	for (int i = 0; i < dataBits; i++)
	{
		data[i] = send[i];
	}

	int* remainderA = new int[genBits - 1];
	for (int i = 0; i < (genBits - 1); ++i)
	{
		remainderA[i] = send[i + dataBits];
	}

	int indent = genBits + 1;

	int array[100][100];

	for (int j = 0; j < genBits; j++)
	{
		array[j][0] = gen[j];
	}
	array[genBits][0] = -1;
	for (int j = 0; j < dataBits; j++)
	{
		array[j + genBits + 1][0] = data[j];
	}
	for (int j = 0; j < genBits - 1; j++)
	{
		array[j + genBits + dataBits + 1][0] = 0;
	}
	array[genBits + genBits + dataBits + 1][0] = -2;

	for (int k = 1; k < MAX_LINES; k++)
	{
		for (int i = 0; i < indent; i++)
		{
			array[i][k] = -1;
		}
		if (k < genBits + dataBits - 1)
		{
			for (int i = 0; i < genBits; i++)
			{

				array[i + indent][k] = gen[i];

			}
			array[indent + genBits][k] = -2;
			k++;
		}
		for (int i = 0; i <= indent; i++)
		{
			array[i][k] = -1;
		}
		skip = true;
		tempIndent = 0;
		for (int i = 0; i < genBits; i++)
		{
			array[i + indent][k] = array[i + indent][k - 2] ^ array[i + indent][k - 1];
			if (array[i + indent][k] == 0)
			{
				if (skip)
				{
					array[i + indent][k] = -1;
					tempIndent++;
				}

			}
			else if (array[i + indent][k] == 1)
			{
				skip = false;
			}

		}
		//cout << tempIndent << endl;
		int p = 0;
		int inc = 0;
		//cout << indent << endl;

		indent = indent + tempIndent;
		for (int i = 0; i < indent; i++)
		{
			if ((array[i + indent][k] < -2) && (inc < tempIndent))
			{
				inc++;
				array[i + indent][k] = array[i + indent][0];
				p = i;
			}
		}
		//cout << p << endl;
		array[p + indent + 1][k] = -2;
	}
	string remainder = "";
	string output = "";
	string temp = "";
	int counter = 0;
	int indentcount = 0;
	for (int i = 0; i < genBits - 1; i++)
	{
		remainder = remainder + '0';
	}
	for (int j = 0; j < 10; j++)
	{
		for (int i = 0; i < 100; i++)
		{
			if (array[i][j] == -2)
			{
				counter++;
				if ((j < (dataBits + genBits - 1)))
				{
					output = output + "\n";
				}

				if (!((counter) % 2 == 1) && !(array[i - 1][j] < -800) && (array[i - 1][j] != -1) && (j < (dataBits + genBits - 1)))
				{
					for (int i = 0; i < indentcount; i++)
					{
						output = output + " ";
					}
					output = output + "----\n";
				}
				indentcount = 0;
				break;
			}

			else if ((array[i][j] == -1) && (j < (dataBits + genBits - 1)))
			{
				indentcount++;
				output = output + " ";
			}
			else if (j < (dataBits + genBits - 1) && (array[i][j] > -800))
			{
				temp = to_string(array[i][j]);
				output = output + temp;
			}

		}
	}
	for (int i = 0; i < output.length(); ++i)
	{
		if ((i > 1) && (output[output.length() - i] == '\n'))
		{
			break;
		}
		if (isdigit(output[output.length() - i]))
		{
			remainder[remainder.length() - i + 1] = output[output.length() - i];
		}
	}


	string sent_bits = "";
	string generator = "";
	string d = "";
	string remainderCheck = "";
	for (int i = 0; i < dataBits; i++)
	{
		d = d + to_string(data[i]);
	}
	for (int i = 0; i < genBits; i++)
	{
		generator = generator + to_string(gen[i]);
	}
	for (int i = 0; i < (genBits - 1); ++i)
	{
		remainderCheck = remainderCheck + to_string(remainderA[i]);
	}
	sent_bits = d + remainder;

	cout << output << endl;

	if (remainderCheck != remainder)
	{
		cout << "Remainders are not the same, message is corrupt." << endl;
	}
	else
	{
		cout << "Remainders are the same, message is good." << endl;
		cout << "Message is: " << d << endl;
	}



}