using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHAssignment9
{
    public class Company
    {

        public string name { get; set; }

        List<Country> countries;

        public int numCountries { get; set; }

        public List<Country> Countries
        {
            get
            {
                return countries;
            }
            set
            {
                countries = value;
            }

        }

        public Country this[string value]
        {
            get
            {
                foreach (Country c in countries)
                {
                    if (c.name == value)
                    {
                        return c;
                    }
                }
                return null;
            }
        }
        public Country this[int value]
        {
            get
            {
                return countries[value];
            }
        }

        public Company(string n)
        {
            countries = new List<Country>();
            name = n;
            numCountries = 0;
        }

        public void AddCountry()
        {
            var secondForm = new AddCountry(this);

            secondForm.ShowDialog();
            

        }

        public void RemoveCountry(string n)
        {
            Country to_remove = countries.Where(x => x.name.Equals(n, StringComparison.CurrentCultureIgnoreCase)).FirstOrDefault();
            countries.Remove(to_remove);
            numCountries = countries.Count;
        }

        public void SortCountries(string v)
        {
            if (v == "name")
            {
                SortByName();
            } else if (v == "size")
            {
                SortBySize();
            } else if (v == "population")
            {
                SortByPopulation();
            }
        }

        public Country HighestPerSqMile()
        {
            Country highest = new Country();
            highest.size = 0;
            foreach (Country c in countries)
            {
                if (c > highest)
                {
                    highest = c;
                }
            }
            return highest;
        }



        private void SortByName()
        {
            countries = countries.OrderBy(x => x.name).ToList();
        }
        private void SortBySize()
        {
            countries = countries.OrderBy(x => x.size).ToList();
        }
        private void SortByPopulation()
        {
            countries = countries.OrderBy(x => x.population).ToList();
        }

    }
}
