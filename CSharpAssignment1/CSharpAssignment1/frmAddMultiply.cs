using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpAssignment1
{
    public partial class frmAddMultiply : Form
    {
        public frmAddMultiply()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnResult1_Click(object sender, EventArgs e)
        {
            bool failedToMath = false;
            int Result;
            int ValueA, ValueB, ValueC;
            failedToMath = Int32.TryParse(txt1.Text, out ValueA);
            failedToMath = Int32.TryParse(txt2.Text, out ValueB);
            failedToMath = Int32.TryParse(txt3.Text, out ValueC);
            if (!failedToMath)
            {
                txt4.Text = "INVALID INPUT";
            } else
            {
                Result = ValueA + (ValueB * ValueC);
                txt4.Text = Result.ToString();
            }

        }

        private void btnResult2_Click(object sender, EventArgs e)
        {
            bool failedToMath = false;
            int Result;
            int ValueA, ValueB, ValueC;
            failedToMath = Int32.TryParse(txt1.Text, out ValueA);
            failedToMath = Int32.TryParse(txt2.Text, out ValueB);
            failedToMath = Int32.TryParse(txt3.Text, out ValueC);
            if (!failedToMath)
            {
                txt5.Text = "INVALID INPUT";
            }
            else
            {
                Result = (ValueA + ValueB) * ValueC;
                txt5.Text = Result.ToString();
            }
        }

        
    }
}
