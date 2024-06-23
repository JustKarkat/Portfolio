using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment10
{
    public class Flight
    {

        public int Code { get; set; }
        public DateTime Departure { get; set; }
        public string Destination { get; set; }
        public List<string> Names { get; set; }

        public Flight() { }
        public Flight(int c, DateTime d, string p, List<string> n)
        {
            Code = c;
            Departure = d;
            Destination = p;
            Names = n;
        }

        public virtual string getUniqueInfo()
        {
            return "default";
        }

    }
}
