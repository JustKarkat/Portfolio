using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment10
{
    class Domestic : Flight
    {
        public bool Food_provided { get; set; }

        public Domestic(int c, DateTime d, string p, List<string> n, bool f) : base(c, d, p, n)
        {
            Food_provided = f;
        }

        public override string getUniqueInfo()
        {
            if (Food_provided)
            {
                return "FoodP";
            }
            else
            {
                return "FoodN";
            }


        }

    }
}

