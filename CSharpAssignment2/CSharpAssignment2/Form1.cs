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

namespace CSharpAssignment2
{
    public partial class Form1 : Form
    {

        double costVanilla, costChocolate;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            costVanilla = 2.5;
            costChocolate = 3.5;
            txtPriceV.Text = costVanilla.ToString("c");
            txtPriceC.Text = costChocolate.ToString("c");
        }

        private void brnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void brnClear_Click(object sender, EventArgs e)
        {
            txtScoopsC.Text = "";
            txtScoopsV.Text = "";
            txtAverageCost.Text = "";
            txtPercVanil.Text = "";
            txtTotalCost.Text = "";

        }

        private void btnAverageCost_Click(object sender, EventArgs e)
        {
            if ((txtScoopsV.Text != "") || (txtScoopsC.Text != ""))
            {
                int vanillaScoops = Int32.Parse(txtScoopsV.Text);
                int chocolateScoops = Int32.Parse(txtScoopsC.Text);
                double totalCost = (costVanilla * vanillaScoops) + (costChocolate * chocolateScoops);
                double averageCost = totalCost / (vanillaScoops + chocolateScoops);
                txtAverageCost.Text = averageCost.ToString("c");
            }
            else
            {
                txtScoopsC.Text = "0";
                txtScoopsV.Text = "0";
            }
        }

        private void btnPercVanil_Click(object sender, EventArgs e)
        {
            if ((txtScoopsV.Text != "") || (txtScoopsC.Text != ""))
            {
                int vanillaScoops = Int32.Parse(txtScoopsV.Text);
                int chocolateScoops = Int32.Parse(txtScoopsC.Text);
                if ((chocolateScoops + vanillaScoops) != 0)
                {
                    double percentVanilla = (Convert.ToDouble(vanillaScoops) / (chocolateScoops + vanillaScoops));
                    txtPercVanil.Text = percentVanilla.ToString("p");
                }
                else
                {
                    txtPercVanil.Text = "N/A";
                }
            }
            else
            {
                txtScoopsC.Text = "0";
                txtScoopsV.Text = "0";
            }
        }

        private void btnTotalCost_Click(object sender, EventArgs e)
        {
            if ((txtScoopsV.Text != "") || (txtScoopsC.Text != ""))
            {
                int vanillaScoops = Int32.Parse(txtScoopsV.Text);
                int chocolateScoops = Int32.Parse(txtScoopsC.Text);
                double totalCost = (costVanilla * vanillaScoops) + (costChocolate * chocolateScoops);
                txtTotalCost.Text = totalCost.ToString("c");
            }
            else
            {
                txtScoopsC.Text = "0";
                txtScoopsV.Text = "0";
                txtTotalCost.Text = 0.ToString("c");
            }
        }
    }
}
