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
    public partial class AddCountry : Form
    {
        public Country newCountry { get; set; }

        public Company local;

        public AddCountry(Company c)
        {
            local = c;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            newCountry = new Country();
            try
            {
                newCountry.name = txtName.Text;
                newCountry.population = long.Parse(txtPopulation.Text);
                newCountry.size = decimal.Parse(txtSize.Text);
                local.Countries.Add(newCountry);
                local.numCountries = local.Countries.Count;
                this.Hide();
            } catch
            {
                MessageBox.Show("Enter all necessary information.");
            }
        }


        private void Clear()
        {

            txtName.Clear();
            txtPopulation.Clear();
            txtSize.Clear();

        }

        private void AddCountry_Load(object sender, EventArgs e)
        {

        }
    }
}
