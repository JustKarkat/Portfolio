using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpAssignment8
{
    public partial class Form1 : Form
    {

        

        SortedList<string, int> destinations = new SortedList<string, int>();
        public static string medicalConcerns = "";
        public static List<Customer> customers = new List<Customer>();
        
        public void Clear()
        {
            txtName.Clear();
            medicalConcerns = "";
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
            string chosenClass = "";

            if (radioBusiness.Checked == true)
            {
                addfromClass = .3;
                chosenClass = "Business";
            }
            else if (radioFirst.Checked == true)
            {
                addfromClass = .55;
                chosenClass = "First";
            }

            try
            {
                if (txtName.Text == "")
                {
                    throw new Exception("Please Enter a Name.");
                }
                allInformation += "Name: " + txtName.Text + "\n";

                Customer current_customer = new Customer(txtName.Text);

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

                TravelDate chosenDate;
                chosenDate.month = comboMonth.SelectedItem.ToString();
                chosenDate.year = comboYear.SelectedItem.ToString();
                current_customer.Date = chosenDate;

                if (comboDestination.SelectedItem.ToString() == "Random")
                {
                    Random rand = new Random();
                    int random_destination = rand.Next(destinations.Keys.Count()); // do not need to do -1 because Random already does that
                    chosendestination = destinations.Keys[random_destination];
                    allInformation += "Destination: " + chosendestination + "\n";

                    current_customer.Destination = chosendestination;

                }
                else
                {
                    chosendestination = comboDestination.SelectedItem.ToString();
                    allInformation += "Destination: " + chosendestination + "\n";
                    current_customer.Destination = chosendestination;
                }
                allInformation += "Cost: " + ((double)destinations[chosendestination] + (destinations[chosendestination] * addfromClass)) + "\n";
                current_customer.Cost = (double)destinations[chosendestination] + (destinations[chosendestination] * addfromClass);
                if (medicalConcerns != "")
                {
                    allInformation += "Medical Requirements:\n" + medicalConcerns + "\n";
                    current_customer.CustomerMedicalConcerns = medicalConcerns;
                }

                
                current_customer.TravelClass = chosenClass;

                DialogResult button;
                button = MessageBox.Show(allInformation, "Are you sure you want to submit?", MessageBoxButtons.YesNo);
                if (button == DialogResult.Yes)
                {
                    Clear();
                    customers.Add(current_customer);
                    MessageBox.Show("Form Submitted!", "Success");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnConcerns_Click(object sender, EventArgs e)
        {
            var concerns = new medical_concerns();

            concerns.Show();

        }

        private void btnShowOne_Click(object sender, EventArgs e)
        {
            
            if (txtName.Text != "")
            {
                List<Customer> tempList = customers.OrderBy(o => o.Name).ToList(); //had a bug with my .equals and .where which was due to the list not being ordered by the name
                Customer match = tempList.Where(x => x.Name.Equals(txtName.Text, StringComparison.CurrentCultureIgnoreCase)).FirstOrDefault(); //I researched how to use .Equals and .Where, etc.
                if (match == null)
                {
                    MessageBox.Show("This Customer does not exist.");
                }
                else
                {
                    match.Display();
                }
            }
            else
            {
                MessageBox.Show("Enter a name into the name box.");
            }

        }

        private void btnDelCustomers_Click(object sender, EventArgs e)
        {
                customers = new List<Customer>();
        }

        private void btnAllCustomer_Click(object sender, EventArgs e)
        {
            var list = new CustomersList();
            list.Show();
        }
    }
}
