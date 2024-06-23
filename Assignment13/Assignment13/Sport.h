#ifndef SPORT_H
#define SPORT_H
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
	std::string* team_names = nullptr;
	char lowest;
	char getLowest() const;
public:
	Sport(const std::string& n = "")
	{
		setName(n);
	}
	~Sport();
	std::string getName() const
	{
		return name;
	}
	void setName(const std::string&);
	Date getDate() const
	{
		return day_scheduled;
	}
	void setDate(const Date&);
	int getTeams() const
	{
		return teams;
	}
	void setTeams(const int&);
	std::string* getTeam_Names() const;
	void setTeam_Names(std::string*);
	void populate();
	void display() const;
};
#endif