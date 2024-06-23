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

namespace CSharpAssignment5
{
    public partial class Form1 : Form
    {

        enum Grade
        {
            A,
            B,
            C,
            D,
            F
        };

        private void clearAll()
        {
            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
            txtOverallScore.Clear();
            txtSalary.Clear();
            txtGrade.Clear();
            txtYears.Clear();
            txtName.Clear();
        }

        private bool validScore(TextBox text)
        {
            bool output = true;
            double tempnum = 0;
            Double.TryParse(text.Text, out tempnum);

            if (tempnum > 100 || tempnum < 0)
            {
                output = false;
            }

            if (!output)
            {
                MessageBox.Show("Value of " + text.Name + " outside of range \"0-100\"", "Percentage Entry");
                text.Clear();
                text.Focus();
            }

            return output;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            bool noError = true;


            Grade gradeAchieved = Grade.A;
            double scoreA = 0, scoreB = 0, scoreC = 0;

            int yearsWorked = 0;

            double overallScore, salaryEarned = 0;

            string nameEmp = txtName.Text;



            try
            {
                if (!Double.TryParse(txtA.Text, out scoreA))
                {
                    txtA.Focus();
                    throw new Exception();
                }
                if (!Double.TryParse(txtB.Text, out scoreB))
                {
                    txtB.Focus();
                    throw new Exception();
                }
                if (!Double.TryParse(txtC.Text, out scoreC))
                {
                    txtC.Focus();
                    throw new Exception();
                }
                if (!Int32.TryParse(txtYears.Text, out yearsWorked))
                {
                    txtYears.Focus();
                    throw new Exception();
                }
                // Code that can be activated if entering a name is required.
                /*if (nameEmp == "")
                {
                    txtName.Focus();
                    throw new Exception("No Value Entered for Name.");
                }*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n" + ex.StackTrace, "Exception");
                noError = false;
            }

            bool validEntry = validScore(txtA) && validScore(txtB) && validScore(txtC) && noError;
            try
            {
                if (validEntry)
                {
                    overallScore = ((.25 * scoreA) + (.35 * scoreB) + (.40 * scoreC));

                    if (overallScore >= 90)
                    {
                        gradeAchieved = Grade.A;
                    }
                    else if ((overallScore >= 80) && (overallScore < 89.99))
                    {
                        gradeAchieved = Grade.B;
                    }
                    else if ((overallScore >= 70) && (overallScore < 79.99))
                    {
                        gradeAchieved = Grade.C;
                    }
                    else if ((overallScore >= 60) && (overallScore < 69.99))
                    {
                        gradeAchieved = Grade.D;
                    }
                    else if (overallScore < 60)
                    {
                        gradeAchieved = Grade.F;
                    }



                    switch (gradeAchieved)
                    {
                        case Grade.A:
                            salaryEarned = 120;
                            break;
                        case Grade.B:
                            salaryEarned = 110;
                            break;
                        case Grade.C:
                            salaryEarned = 90;
                            break;
                        case Grade.D:
                            salaryEarned = 75;
                            break;
                        case Grade.F:
                            salaryEarned = 35;
                            break;
                        default:
                            salaryEarned = 0;
                            break;
                    }

                    if (yearsWorked >= 5 && yearsWorked < 10)
                    {
                        salaryEarned += (salaryEarned * .02);
                    }
                    else if ( yearsWorked >= 10)
                    {
                        salaryEarned += (salaryEarned * .05);
                    }
                    

                    txtGrade.Text = gradeAchieved.ToString();
                    txtOverallScore.Text = (overallScore / 100).ToString("p2");
                    txtSalary.Text = (salaryEarned * 1000).ToString("c");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n" +ex.StackTrace, "Exception");
            }
        }
    }
}
