using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSHAssignment9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Company maincompany = new Company("Company");
        private void Form1_Load(object sender, EventArgs e)
        {
            lblCompanyName.Text = maincompany.name;
            radioName.Select();

            string[] names = { "United Kingdom", "Thailand", "China", "United States", "Japan", "France", "South Africa", "Canada", "Australia", "Ghana", "Uzbekistan"};
            long[] populations = { 67530172, 69037513, 1433783686, 329064917, 126860301, 65129728, 58558270, 37411047, 25203198, 31072940, 33469203};
            decimal[] sizes = { 93410, 197260, 3600950, 3531925, 140752, 247270, 468910, 3511023, 2947366, 87851, 172700};
            
            for (int i = 0; i < names.Length; i++)
            {
                Country tempCountry = new Country(names[i], populations[i], sizes[i]);
                maincompany.Countries.Add(tempCountry);
                maincompany.numCountries += 1;
            }
            updateListBox();
        }


        private void updateListBox()
        {
            listCountries.Items.Clear();
            foreach (Country c in maincompany.Countries)
            {
                listCountries.Items.Add(c.name);
            }
        }

        private void btnAddCountry_Click(object sender, EventArgs e)
        {
            maincompany.AddCountry();
            updateListBox();
        }

        private void btnRemoveCountry_Click(object sender, EventArgs e)
        {
            maincompany.RemoveCountry(txtRemove.Text);
            updateListBox();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            Country display = maincompany.Countries.Where(x => x.name.Equals(txtDisplay.Text, StringComparison.CurrentCultureIgnoreCase)).FirstOrDefault();
            MessageBox.Show("Name: " + display.name + "\n" + "Population: " + display.population.ToString() + "\n" + "Size: " + display.size.ToString(), "Current Country");
        }

        private void btnLargest_Click(object sender, EventArgs e)
        {
            Country display = maincompany.HighestPerSqMile();
            MessageBox.Show("Name: " + display.name + "\n" + "Population: " + display.population.ToString() + "\n" + "Size: " + display.size.ToString(), "Current Country");
        }


        private void btnSort_Click(object sender, EventArgs e)
        {
            if (radioName.Checked)
            {
                maincompany.SortCountries("name");
            }
            if (radioPopulation.Checked)
            {
                maincompany.SortCountries("population");
            }
            if (radioSize.Checked)
            {
                maincompany.SortCountries("size");
            }
            updateListBox();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCurrentNum_Click(object sender, EventArgs e)
        {
            MessageBox.Show(maincompany.numCountries.ToString(), "Number of Countries");
        }
    }
}
