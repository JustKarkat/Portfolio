#include <iostream>
#include <iomanip>
#include <string>
using namespace std;


string pigLatin()
{
	unsigned int j = 0;
	unsigned int i = 0;

	string input;

	getline(cin, input);

	char currentchar;

	bool hitvowel = false;
	string temp;

	string piglatinified[127];
	j = 0;

	for (size_t i = 1; i < input.length(); i++)
	{
		piglatinified[j] = temp;

		cout << temp << endl;

		if (input[i] == ' ')
		{
			j++;
		}
		
	}
	return input;
}



int main()
{
	string output;

	cout << "Enter your phrase to convert to Pig Latin: ";
	output = pigLatin();
}