// Written by Rogan Helm
// 10/7/22

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWebApp.Models
{
    public abstract class Person
    {
        private string firstName = "n/a";
        private string lastName = "n/a";
        private string address = "n/a";
        private string city = "n/a";
        private string state = "n/a";
        private string zipCode = "n/a";

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }
        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }
        public string City
        {
            get { return this.city; }
            set { this.city = value; }
        }
        public string State
        {
            get { return this.state; }
            set { this.state = value; }
        }
        public string ZipCode
        {
            get { return this.zipCode; }
            set { this.zipCode = value; }
        }
        public virtual string AddClass()
        {
            return "The person has added a class";
        }
        public abstract string DropClass();
    }
}
