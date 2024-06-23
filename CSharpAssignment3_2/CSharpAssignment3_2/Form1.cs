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

namespace CSharpAssignment3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tipStatus.ToolTipTitle = "Tip";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerStatus.Text = "";
            txtDiscount.Text = "";
            txtExecRoom.Text = "";
            txtNetCost.Text = "";
            txtTotalCost.Text = "";
            nummericDays.Value = 0;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int numDays = (int)nummericDays.Value;
            bool execRoom = false;
            double discount = 0;
            double totalCost;

            //Gets Executive Room and sets boolean to value based on input.
            if (txtExecRoom.Text.ToUpper() == "Y")
            {
                execRoom = true;
            }
            else if (txtExecRoom.Text.ToUpper() == "N")
            {
                execRoom = false;
            }
            else
            {
                txtExecRoom.Text = "Invalid Input";
            }
            //Gets Value from Customer Status and sets % value.
            if (txtCustomerStatus.Text.ToUpper() == "G")
            {
                if (numDays >= 2 && numDays <=6)
                {
                    discount = 0.20;
                }
                else if (numDays >= 7)
                {
                    discount = 0.30;
                }
            }
            else if(txtCustomerStatus.Text.ToUpper() == "P")
            {
                if (numDays >= 2 && numDays <= 5)
                {
                    discount = 0.30;
                }
                else if (numDays >= 6)
                {
                    discount = 0.35;
                }
            }
            else if (txtCustomerStatus.Text.ToUpper() == "R")
            {
                discount = 0; 
            }
            else
            {
                txtCustomerStatus.Text = "Invalid Input";
            }

            if (execRoom)
            {
                totalCost = (70.00 * numDays);
            }
            else
            {
                totalCost = (50.00 * numDays);
            }

            txtTotalCost.Text = totalCost.ToString("c");

            txtDiscount.Text = (discount).ToString("p1");

            txtNetCost.Text = (totalCost - (discount * totalCost)).ToString("c");

        }
    }
}
