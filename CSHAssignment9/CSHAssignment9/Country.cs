using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHAssignment9
{
    public class Country
    {
        public string name { get; set; }

        public long population { get; set; }

        public decimal size { get; set; }

        public Country() { }

        public Country(string n, long p, decimal s)
        {
            name = n;
            population = p;
            size = s;
        }

        public static bool operator > (Country c1, Country c2)
        {
            if (c1.size > c2.size)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator < (Country c1, Country c2)
        {
            return !(c1.size > c2.size);
        }
    }
}
