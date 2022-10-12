// Written by Rogan Helm
// 10/12/22

namespace OpenACSVFile.Models
{
    public class Person
    {
        // Class variables
        private int id = 0;
        private string firstName = "n/a";
        private string lastName = "n/a";

        // Gets & Sets
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        // Constructors
        public Person() : this(0, "n/a", "n/a") { }
        public Person(int anId, string aFirstName, string aLastName)
        {
            Id = anId;
            FirstName = aFirstName;
            LastName = aLastName;
        }

        // Method
        public override string ToString()
        {
            return Id + "\t" + LastName + "\t" + FirstName;
        }
    }
}
