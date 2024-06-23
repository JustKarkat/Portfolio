using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment10
{
    public class Airline
    {
        public string Name { get; set; }
        public List <Flight> Flights { get; set; }

        public Airline() { }
        public Airline(string n, List<Flight> f)
        {
            Name = n;
            Flights = f;
        }

    }
}
