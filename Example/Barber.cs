using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    public class Barber: ICut
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
        public Barber() : this("n/a", "n/a") { }
        public Barber(string aFirstName, string aLastName)
        {
            this.FirstName = aFirstName;
            this.LastName = aLastName;
        }
        public override string Cut()
        {
            return "The barber cuts hair.";
        }
    }
}
