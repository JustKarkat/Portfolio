using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpAssignment10
{
    public partial class mainForm : Form
    {
        public Airline ex_airline = new Airline("Example Airlines", new List<Flight>());

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            Random randomnum = new Random();
            List<string> generic_names = new List<string>();
            for (int i = 0; i < 10; ++i)
            {
                generic_names.Add("John Doe" + randomnum.Next().ToString());
            }
            lblAirline.Text = lblAirline.Name;
            List<Flight> flights = new List<Flight>();
            flights.Add(new Domestic(203, DateTime.Now, "Texas, United States", generic_names, true));
            flights.Add(new Domestic(204, DateTime.Now, "Missouri, United States", generic_names, true));
            flights.Add(new Domestic(205, DateTime.Now, "Nevada, United States", generic_names, false));
            flights.Add(new Domestic(207, DateTime.Now, "California, United States", generic_names, true));
            flights.Add(new International(405, DateTime.Now, "Berlin, Germany", generic_names, false));
            flights.Add(new International(506, DateTime.Now, "Quebec, Canada", generic_names, true));
            flights.Add(new International(566, DateTime.Now, "Arizona, United States", generic_names, false));
            flights.Add(new International(916, DateTime.Now, "Tokyo, Japan", generic_names, true));

            ex_airline.Flights = flights;
            lblAirline.Text = ex_airline.Name;
            radioAll.Checked = true;
            foreach (var f in ex_airline.Flights)
            {
                if (f.getUniqueInfo() == "default")
                {
                    listFlights.Items.Add("Flight #" + f.Code + " / " + f.Destination + " / " + f.Departure.ToString());
                }
                else if (f.getUniqueInfo() == "VisaR")
                {
                    listFlights.Items.Add("Flight #" + f.Code + " / " + f.Destination + " / " + f.Departure.ToString() + " / " + "Visa");
                }
                else if (f.getUniqueInfo() == "VisaN")
                {
                    listFlights.Items.Add("Flight #" + f.Code + " / " + f.Destination + " / " + f.Departure.ToString() + " / " + "No Visa");
                }
                else if (f.getUniqueInfo() == "FoodP")
                {
                    listFlights.Items.Add("Flight #" + f.Code + " / " + f.Destination + " / " + f.Departure.ToString() + " / " + "Food");
                }
                else if (f.getUniqueInfo() == "FoodN")
                {
                    listFlights.Items.Add("Flight #" + f.Code + " / " + f.Destination + " / " + f.Departure.ToString() + " / " + "No Food");
                }
            }
    }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == "")
                {
                    throw new Exception("Please Enter a Name.");
                }
                if (listFlights.SelectedIndex < 0)
                {
                    throw new Exception("Please Choose a Flight.");
                }
                ex_airline.Flights[listFlights.SelectedIndex].Names.Add(txtName.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnListFlights_Click(object sender, EventArgs e)
        {
            listFlights.Items.Clear();
            if (radioAll.Checked)
            {
                foreach (var f in ex_airline.Flights)
                {
                    if (f.getUniqueInfo() == "default")
                    {
                        listFlights.Items.Add("Flight #" + f.Code + " / " + f.Destination + " / " + f.Departure.ToString());
                    }
                    else if (f.getUniqueInfo() == "VisaR")
                    {
                        listFlights.Items.Add("Flight #" + f.Code + " / " + f.Destination + " / " + f.Departure.ToString() + " / " + "Visa");
                    }
                    else if (f.getUniqueInfo() == "VisaN")
                    {
                        listFlights.Items.Add("Flight #" + f.Code + " / " + f.Destination + " / " + f.Departure.ToString() + " / " + "No Visa");
                    }
                    else if (f.getUniqueInfo() == "FoodP")
                    {
                        listFlights.Items.Add("Flight #" + f.Code + " / " + f.Destination + " / " + f.Departure.ToString() + " / " + "Food");
                    }
                    else if (f.getUniqueInfo() == "FoodN")
                    {
                        listFlights.Items.Add("Flight #" + f.Code + " / " + f.Destination + " / " + f.Departure.ToString() + " / " + "No Food");
                    }
                }
            } else if (radioDomest.Checked)
            {
                foreach (var f in ex_airline.Flights)
                {
                    if (f.getUniqueInfo() == "FoodP")
                    {
                        listFlights.Items.Add("Flight #" + f.Code + " / " + f.Destination + " / " + f.Departure.ToString() + " / " + "Food");
                    }
                    else if (f.getUniqueInfo() == "FoodN")
                    {
                        listFlights.Items.Add("Flight #" + f.Code + " / " + f.Destination + " / " + f.Departure.ToString() + " / " + "No Food");
                    }
                }
            } else if (radioInt.Checked)
            {
                foreach (var f in ex_airline.Flights)
                {
                    if (f.getUniqueInfo() == "VisaR")
                    {
                        listFlights.Items.Add("Flight #" + f.Code + " / " + f.Destination + " / " + f.Departure.ToString() + " / " + "Visa");
                    }
                    else if (f.getUniqueInfo() == "VisaN")
                    {
                        listFlights.Items.Add("Flight #" + f.Code + " / " + f.Destination + " / " + f.Departure.ToString() + " / " + "No Visa");
                    }
                }
            }
        }

        private void btnShowFlight_Click(object sender, EventArgs e)
        {
            try
            {
                if (listFlights.SelectedIndex < 0)
                {
                    throw new Exception("Please Choose a Flight.");
                }
                FlightInfo flights = new FlightInfo(ex_airline.Flights[listFlights.SelectedIndex].Code, ex_airline.Flights[listFlights.SelectedIndex].Names);

                flights.Show();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
