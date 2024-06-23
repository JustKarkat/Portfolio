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
    public partial class FlightInfo : Form
    {

        int flight_code;
        List<string> passengers;


        public FlightInfo(int c, List<string> p)
        {
            InitializeComponent();
            flight_code = c;
            passengers = p;
        }

        private void FlightInfo_Load(object sender, EventArgs e)
        {
            lblFlight.Text = "Flight #" + flight_code.ToString() + " Info";
            foreach (var p in passengers)
            {
                listPassengers.Items.Add(p);
            }
        }
    }
}
