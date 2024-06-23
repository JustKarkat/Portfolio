using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CSharpAssignment6_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private SortedList<string, int> sports = new SortedList<string, int>();

        

        private void Form1_Load(object sender, EventArgs e)
        {
            sports.Add("Squash", 25);
            sports.Add("Table Tennis", 30);
            sports.Add("Football", 105);
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnAddSport_Click(object sender, EventArgs e)
        {
            if (txtRemSportName.Text != "")
            {
                sports.Add(txtNewSport.Text, (int)numNewSportParticipants.Value);
            }
            else
            {
                MessageBox.Show("Please enter a sport name.");
            }
        }

        private void btnRemSport_Click(object sender, EventArgs e)
        {
            if (txtRemSportName.Text != "")
            {
                if (sports.ContainsKey(txtRemSportName.Text))
                {
                    sports.Remove(txtRemSportName.Text);
                } else
                {
                    MessageBox.Show("Sport is not within the list. (case-sensitive)");
                }
            }
            else
            {
                MessageBox.Show("Please enter a sport name.");
            }
            

        }

        private void btnSpecSport_Click(object sender, EventArgs e)
        {
            if (sports.ContainsKey(txtSpecificSport.Text))
            {
                MessageBox.Show(txtSpecificSport.Text + " has " + sports[txtSpecificSport.Text].ToString() + " participants.", "Specific Sport Info");
            }
            else
            {
                MessageBox.Show("Sport is not within the list. (case-sensitive)");
            }
        }

        private void btnListAll_Click(object sender, EventArgs e)
        {
            string output = "";
            foreach (KeyValuePair<string,int> std in sports)
            {
                output += std.Key + " has " + std.Value.ToString() + " participants.\n";
            }
            MessageBox.Show(output, "All Sports");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNewSport.Clear();
            txtRemSportName.Clear();
            txtSpecificSport.Clear();
            numNewSportParticipants.Value = 0;
        }

        private void btnHighestParticipant_Click(object sender, EventArgs e)
        {
            int highest_Value = sports.Values[0];
            string highest_Key = sports.Keys[0];
            foreach (KeyValuePair<string, int> std in sports)
            {
                if (std.Value > highest_Value)
                {
                    highest_Value = std.Value;
                    highest_Key = std.Key;
                }
            }
            MessageBox.Show(highest_Key + " has the most participants at " + highest_Value.ToString() + " participants.");
        }
    }
}
