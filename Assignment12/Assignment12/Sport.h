#include <string>

struct Date
{
	int day;
	int month;
	int year;
};


class Sport
{
private:
	std::string name;
	Date day_scheduled;
	int teams;
	char lowest;
public:
	std::string getName() const;
	void setName(const std::string&);
	Date getDate() const;
	void setDate(const Date&);
	int getTeams() const;
	void setTeams(const int&);

	char getLowest() const;

	void populate();
	void display() const;
};
