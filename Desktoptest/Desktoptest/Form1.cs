using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Desktoptest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExecute_Click_1(object sender, EventArgs e)
        {
            SortedList<string, DateTime> employees = new SortedList<string, DateTime>();
            employees.Add("D", DateTime.Parse("2/2/2020"));
            employees.Add("A", DateTime.Parse("2/2/2020"));
            employees.Add("F", DateTime.Parse("2/2/2020"));
            employees.Add("Z", DateTime.Parse("2/2/2020"));
            employees.Add("E", DateTime.Parse("2/2/2020"));
            string output = "";
            foreach (KeyValuePair<string, DateTime> employee in employees) { if (employee.Value.Year == DateTime.Now.Year) { output += employee.Key + "\n"; } }
            MessageBox.Show(output, "From This Year");
        }
    }
}
