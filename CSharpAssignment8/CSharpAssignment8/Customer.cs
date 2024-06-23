using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CSharpAssignment8
{
    public struct TravelDate
    {
        public string year;
        public string month;
    };
    public class Customer
    {
        private string name;

        public Customer(string n)
        {
            name = n;
        }
        
        private string travelClass = "Economy";
        private TravelDate date;
        private string destination;
        private double cost;
        private string custMedicalConcerns;
       
        public string TravelClass
        {
            get
            {
                return travelClass;
            }
            set
            {
                travelClass = value;
            }
        }
        public TravelDate Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }
        public string Destination
        {
            get
            {
                return destination;
            }
            set
            {
                destination = value;
            }
        }
        public double Cost
        {
            get
            {
                return cost;
            }
            set
            {
                cost = value;
            }
        }
        public string CustomerMedicalConcerns
        {
            get
            {
                return custMedicalConcerns;
            }
            set
            {
                    custMedicalConcerns = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
        }

        public void Display()
        {
            string message = "Name: " + this.name + "\n"
                + "Travel Class: " + this.travelClass + "\n"
                + "Travel Date: " + this.date.month + " " + this.date.year + "\n"
                + "Cost: " + this.cost.ToString("c") + "\n"
                + "Destination: " + this.destination + "\n"
                + "Medical Concerns: " + this.custMedicalConcerns;
            MessageBox.Show(message, this.name);
        }

    }
}
