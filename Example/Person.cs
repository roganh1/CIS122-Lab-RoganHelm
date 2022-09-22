using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    public abstract class Person: ICut
    {
        private string firstName = "n/a";
        private string lastName = "n/a";
        public string FirstName
        {
            get { return firstName; }
            set { this.firstName = value; }
        }
        public string LastName
        {
            get { return LastName; }
            set { this.LastName = value; }
        }
        public Person() : this("n/a", "n/a") { }
        public Person(string aFirstName, string aLastName)
        {
            this.FirstName = aFirstName;
            this.LastName = aLastName;
        }
        public virtual string Cut()
        {
            return "The person's Cut method";
        }
        public override string ToString()
        {
            string message = "";
        }
        //Alternatively,
        //public abstract string Cut();
    }
}
