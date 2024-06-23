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

namespace CSharpAssignment6_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string[] sports = new string[] { "Squash", "Table Tennis", "Football" };
        private int[] numParticipants = new int[] { 25, 30, 105 };


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnAddSport_Click(object sender, EventArgs e)
        {
            if(txtNewSport.Text != "")
            {
                string[] tempstringarray = new string[sports.Length + 1];
                int[] tempintarray = new int[numParticipants.Length + 1];

                for (int i = 0; i < sports.Length; i++)
                {
                    tempstringarray[i] = sports[i];
                    tempintarray[i] = numParticipants[i];
                }
                tempstringarray[tempstringarray.Length - 1] = txtNewSport.Text;
                tempintarray[tempstringarray.Length - 1] = (int)numNewSportParticipants.Value;
                sports = tempstringarray;
                numParticipants = tempintarray;
            } else
            {
                MessageBox.Show("Please input a name.");
            }
            

        }

        private void btnRemSport_Click(object sender, EventArgs e)
        {
            if (txtRemSportName.Text != "")
            {
                    string[] tempstringarray = new string[sports.Length - 1];
                int[] tempintarray = new int[numParticipants.Length - 1];

                string[] sportsCopy = sports;
                int[] participantsCopy = numParticipants;

                string storedstring = "";
                int storedint = 0;
                bool foundItem = false;

                for (int i = 0; i < sports.Length; i++)
                {
                    if (sports[i].ToUpper() == txtRemSportName.Text.ToUpper())
                    {
                        foundItem = true;
                        storedstring = sportsCopy[i];
                        sportsCopy[i] = sportsCopy[sports.Length - 1];
                        sportsCopy[sports.Length - 1] = storedstring;
                        storedint = participantsCopy[i];
                        participantsCopy[i] = participantsCopy[sports.Length - 1];
                        participantsCopy[sports.Length - 1] = storedint;
                    }
                }
                if (!foundItem)
                {
                    MessageBox.Show("Item Not Found.\n Enter Valid Sport Name.");
                }
                if (foundItem)
                {
                    for (int i = 0; i < tempstringarray.Length; i++)
                    {
                        tempstringarray[i] = sportsCopy[i];
                        tempintarray[i] = participantsCopy[i];
                    }
                    sports = tempstringarray;
                    numParticipants = tempintarray;
                }
            }
            else
            {
                MessageBox.Show("Please input a name.");
            }
        }

        private void btnSpecSport_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < sports.Length; i++)
            {
                if (sports[i].ToUpper() == txtSpecificSport.Text.ToUpper())
                {
                    MessageBox.Show(sports[i] + ": " + numParticipants[i], "Specific Sport Info");
                    break;
                }
            }
        }

        private void btnListAll_Click(object sender, EventArgs e)
        {
            string sportinfo = "";
            for (int i = 0; i < sports.Length; i++)
            {
                sportinfo += sports[i].ToString() + ": " + numParticipants[i].ToString() + "\n";
            }
            MessageBox.Show(sportinfo, "All Sport Info");
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
            int highest = numParticipants[0];
            int highest_index = 0;
            for (int i = 1; i < numParticipants.Length; i++)
            {
                if (numParticipants[i] > highest)
                {
                    highest = numParticipants[i];
                    highest_index = i;
                }
            }
            MessageBox.Show(sports[highest_index] + " has the highest number of participants at " + numParticipants[highest_index] + " participants.", "Highest Participants");
        }
    }
}
