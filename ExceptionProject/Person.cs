using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionProject
{
    public class Person
    {
        private int id = -1;
        private string firstName = "n/a";
        private string lastName = "n/a";

        public int Id { get { return id; } set { this.id = value; } }
        public string FirstName { get { return this.firstName; } set { this.firstName = value; } }
        public string LastName { get { return this.lastName; } set { this.lastName = value; } }

        public Person():this(-1, "n/a", "n/a") { }
        public Person(int anId, string aFirstName, string aLastName)
        {
            Id = anId;
            FirstName = aFirstName;
            LastName = aLastName;
        }

        public override string ToString()
        {
            return this.Id + "\t" + this.LastName + ", " + this.FirstName;
        }
    }
}
