using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    public class Director: ICut
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
        public Director() : this("n/a", "n/a") { }
        public Director(string aFirstName, string aLastName)
        {
            this.FirstName = aFirstName;
            this.LastName = aLastName;
        }
        public string Cut()
        {
            return "The director makes a cut in the scene";
        }
    }
}
