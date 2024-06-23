using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpAssignment9
{
    public partial class Form1 : Form
    {
        SortedList<string, int> destinations = new SortedList<string, int>();

        public void Clear()
        {
            txtName.Clear();
            richConcerns.Clear();
            comboYear.Text = "Select a Year";
            comboMonth.Text = "Select a Month";
            comboDestination.Text = "Select your Destination";
            radioBusiness.Checked = false;
            radioFirst.Checked = false;
            radioEconomy.Checked = true;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[] Years = { DateTime.Now.Year, DateTime.Now.Year + 1, DateTime.Now.Year + 2, DateTime.Now.Year + 3, DateTime.Now.Year + 4, DateTime.Now.Year + 5 };
            foreach (var year in Years)
            {
                comboYear.Items.Add(year);
            }
            string[] Months = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthNames; //I looked up the proper documenation to get a localized list of months online.
            foreach (var month in Months)
            {
                if (month != "")
                {
                    comboMonth.Items.Add(month);
                }
            }


            destinations.Add("England", 500);
            destinations.Add("Canada", 250);
            destinations.Add("China", 550);
            destinations.Add("Australia", 750);
            destinations.Add("Italy", 600);
            destinations.Add("Ecuador", 350);
            destinations.Add("Thailand", 650);


            foreach (KeyValuePair<string, int> destination in destinations)
            {
                comboDestination.Items.Add(destination.Key);
            }

            comboDestination.Items.Add("Random");
            radioEconomy.Checked = true;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string allInformation = "";
            string chosendestination = "";

            double addfromClass = 0.00; // economy

            if (radioBusiness.Checked == true)
            {
                addfromClass = .3;
            }
            else if (radioFirst.Checked == true)
            {
                addfromClass = .55;
            }

            try
            {
                if (txtName.Text == "")
                {
                    throw new Exception("Please Enter a Name.");
                }
                allInformation += "Name: " + txtName.Text + "\n";
                if (comboMonth.SelectedIndex == -1)
                {
                    throw new Exception("Please Select a Month.");
                }
                if (comboYear.SelectedIndex == -1)
                {
                    throw new Exception("Please Select a Year.");
                }
                if (comboDestination.SelectedIndex == -1)
                {
                    throw new Exception("Please Select a Destination.");
                }
                allInformation += "Date of Travel: " + comboMonth.SelectedItem.ToString() + " " + comboYear.SelectedItem.ToString() + "\n";
                if (comboDestination.SelectedItem.ToString() == "Random")
                {
                    Random rand = new Random();
                    int random_destination = rand.Next(destinations.Keys.Count()); // do not need to do -1 because Random already does that
                    chosendestination = destinations.Keys[random_destination];
                    allInformation += "Destination: " + chosendestination + "\n";
                }
                else
                {
                    chosendestination = comboDestination.SelectedItem.ToString();
                    allInformation += "Destination: " + chosendestination + "\n";
                }
                allInformation += "Price: " + ((double)destinations[chosendestination] + (destinations[chosendestination] * addfromClass)) + "\n";
                if (richConcerns.Text != "")
                {
                    allInformation += "Medical Requirements:\n" + richConcerns.Text + "\n";
                }
                DialogResult button;
                button = MessageBox.Show(allInformation, "Are you sure you want to submit?", MessageBoxButtons.YesNo);
                if (button == DialogResult.Yes)
                {
                    Clear();
                    MessageBox.Show("Form Submitted!", "Success");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
