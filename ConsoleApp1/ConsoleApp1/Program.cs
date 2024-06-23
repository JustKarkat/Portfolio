using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            string s1 = "Value1";

            string s2 = "Value2";

            double d1 = 12.5;

            double d2 = 135.67899;

            Console.WriteLine(s2 + ": " + (d2 / 100).ToString("p"));

        }
    }
}
