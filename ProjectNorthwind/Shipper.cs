// Written by Rogan Helm

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNorthwind
{
    internal class Shipper
    {
        //Class variables
        private int shipperId = -1;
        private string companyName = "n/a";
        private string phone = "n/a";

        //Gets and sets
        public int ShipperId
        {
            get { return this.shipperId; }
            set
            {
                if(value > -1) { this.shipperId = value; }
                else { this.shipperId = 0; }
            }
        }
        public string CompanyName { get { return this.companyName; } set { this.companyName = value; } }
        public string Phone { get { return this.phone; } set { this.phone = value; } }

        //Methods
        public override string ToString()
        {
            string message = "";
            message = message + "Shipper ID: " + this.ShipperId + "\n";
            message = message + "Company Name: " + this.CompanyName + "\n";
            message = message + "Phone: " + this.Phone + "\n";
            return message;
        }
        public Shipper()
        {
            //Empty constructor
        }
        public Shipper(int shipperId, string companyName, string phone)
        {
            ShipperId = shipperId;
            CompanyName = companyName;
            Phone = phone;
        }
    }
}
