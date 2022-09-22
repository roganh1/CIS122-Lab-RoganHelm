using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNorthwind
{
    internal class Supplier
    {
        //Class variables
        private int supplierId = -1;
        private string companyName = "n/a";
        private string contactName = "n/a";
        private string contactTitle = "n/a";
        private string address = "n/a";
        private string city = "n/a";
        private string region = "n/a";
        private string postalCode = "n/a";
        private string country = "n/a";
        private string phone = "n/a";
        private string fax = "n/a";
        private string homePage = "n/a";

        //Gets and sets
        public int SupplierId
        {
            get { return this.supplierId; }
            set
            {
                if(value > -1) { this.supplierId = value; }
                else { this.supplierId = 0; }
            }
        }
        public string CompanyName { get { return this.companyName; } set { this.companyName = value; } }
        public string ContactName { get { return this.contactName; } set { this.contactName = value; } }
        public string ContactTitle { get { return this.contactTitle; } set { this.contactTitle = value; } }
        public string Address { get { return this.address; } set { this.address = value; } }
        public string City { get { return this.city; } set { this.city = value; } }
        public string Region { get { return this.region; } set { this.region = value; } }
        public string PostalCode { get { return this.postalCode; } set { this.postalCode = value; } }
        public string Country { get { return this.country; } set { this.country = value; } }
        public string Phone { get { return this.phone; } set { this.phone = value; } }
        public string Fax { get { return this.fax; } set { this.fax = value; } }
        public string HomePage { get { return this.homePage; } set { this.homePage = value; } }

        //Methods
        public override string ToString()
        {
            string message = "";
            message = message + "Supplier ID: " + this.SupplierId + "\n";
            message = message + "Company Name: " + this.CompanyName + "\n";
            message = message + "Contact Name: " + this.ContactName + "\n";
            message = message + "Contact Title: " + this.ContactTitle + "\n";
            message = message + "Address: " + this.Address + "\n";
            message = message + "City: " + this.City + "\n";
            message = message + "Region: " + this.Region + "\n";
            message = message + "Postal Code: " + this.PostalCode + "\n";
            message = message + "Country: " + this.Country + "\n";
            message = message + "Phone: " + this.Phone + "\n";
            message = message + "Fax: " + this.Fax + "\n";
            message = message + "Home Page: " + this.HomePage + "\n";
            return message;
        }
        public Supplier()
        {
            //Empty constructor
        }
        public Supplier(int supplierId, string companyName, string contactName, string contactTitle, string address, string city, string region, string postalCode, string country, string phone, string fax, string homePage)
        {
            SupplierId = supplierId;
            CompanyName = companyName;
            ContactName = contactName;
            ContactTitle = contactTitle;
            Address = address;
            City = city;
            Region = region;
            PostalCode = postalCode;
            Country = country;
            Phone = phone;
            Fax = fax;
            HomePage = homePage;
        }
    }
}
