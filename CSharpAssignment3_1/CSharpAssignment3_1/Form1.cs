using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace CSharpAssignment3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            txtYearlyPop.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            txtYearlyPop.Text = "";
            txtToReach.Text = "";
            double GrowthRate;
            bool GrowBool = Double.TryParse(txtGrowRate.Text, out GrowthRate);
            int currentPopulation;
            bool CurBool = Int32.TryParse(txtCurPop.Text, out currentPopulation);
            int targetPopulation;
            bool TarBool = Int32.TryParse(txtTarPop.Text, out targetPopulation);
            if (!GrowBool || !CurBool || !TarBool)
            {
                txtYearlyPop.Text = "PLEASE ENTER VALID INPUT.";
            }
            else
            {
                int yearsToReach = 1;

                int yearlyPopulation = (int)(currentPopulation + (GrowthRate / 100) * currentPopulation);
                txtYearlyPop.Text = txtYearlyPop.Text + yearlyPopulation.ToString() + "\n";
                do
                {
                    yearsToReach += 1;
                    yearlyPopulation += (int)(yearlyPopulation * (GrowthRate / 100));
                    txtYearlyPop.Text = txtYearlyPop.Text + yearlyPopulation.ToString() + "\n";
                } while (yearlyPopulation <= targetPopulation);
                txtToReach.Text = yearsToReach.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtYearlyPop.Text = "";
            txtToReach.Text = "";
            txtGrowRate.Text = "";
            txtCurPop.Text = "";
            txtTarPop.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
