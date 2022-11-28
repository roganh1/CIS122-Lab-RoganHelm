// Written by Rogan Helm
// 11/15/22
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayflower_Passengers
{
    public class Person
    {
        private string firstName = "n/a";
        private string lastName = "n/a";

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }

        public Person() : this("none", "none")
        {
        }

        public Person(string aFirstName, string aLastName)
        {
            this.FirstName = aFirstName;
            this.LastName = aLastName;
        }

        public override string ToString()
        {
            string message = string.Empty; // Unsure whether or not string.Empty is better than "" in terms of memory usage / bloat
            message = message + "First Name: " + this.FirstName + "\n";
            message = message + "Last Name: " + this.LastName + "\n";
            return message;
        }
    }
}
