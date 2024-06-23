using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment10
{
    class International : Flight
    {

        public bool Visa_required { get; set; }

        public International(int c, DateTime d, string p, List<string> n, bool v) : base(c, d, p, n)
        {
            Visa_required = v;
        }

        public International() { }

        public override string getUniqueInfo()
        {
            if (Visa_required)
            {
                return "VisaR";
            }
            else
            {
                return "VisaN";
            }

        }
    }
}
