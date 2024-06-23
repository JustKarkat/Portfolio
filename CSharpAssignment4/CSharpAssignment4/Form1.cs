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

namespace CSharpAssignment4
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
            numHours.Value = 0;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelHoursWorked.Enabled = false;
            radioFull.Checked = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioPart_CheckedChanged(object sender, EventArgs e)
        {
            panelHoursWorked.Enabled = true;
        }

        private void radioFull_CheckedChanged(object sender, EventArgs e)
        {
            panelHoursWorked.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Grade gradeAchieved = Grade.A;
            double scoreA, scoreB, scoreC;
            bool isPartTime = false;

            double overallScore, salaryEarned = 0;

            if(radioFull.Checked)
            {
                isPartTime = false;
            } else if(radioPart.Checked)
            {
                isPartTime = true;
            }

            Double.TryParse(txtA.Text, out scoreA);
            Double.TryParse(txtB.Text, out scoreB);
            Double.TryParse(txtC.Text, out scoreC);

            overallScore = ((.25 * scoreA) + (.35* scoreB) + (.40 * scoreC));

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

            if (isPartTime)
            {
                salaryEarned = (double)(numHours.Value / 40) * salaryEarned;
            }

            

            txtGrade.Text = gradeAchieved.ToString();
            txtOverallScore.Text = (overallScore / 100).ToString("p2");
            txtSalary.Text = (salaryEarned * 1000).ToString("c");
        }
    }
}
