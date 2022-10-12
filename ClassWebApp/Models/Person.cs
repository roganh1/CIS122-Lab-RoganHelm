// Written by Rogan Helm
// 10/7/22

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWebApp.Models
{
    public class Student : Person
    {
        // Class variables go here
        private string studentId = "n/a";
        private string firstName = "n/a";
        private string lastName = "n/a";
        private string address = "n/a";
        private string city = "n/a";
        private string state = "n/a";
        private string zipCode = "n/a";
        // The 2 lines below are for illustrative purposes
        private double diningDollars = 0.0;
        private string socialSecurityNum = "n/a";
        private List<Professor> advisors = new List<Professor>();

        // Public properties
        // Data encapsulation
        public string StudentId
        {
            get { return this.studentId; }
            //set { this.studentId = value; }
        }
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
        public double DiningDollars
        {
            get { return this.diningDollars; }
            set
            {
                if (value < 0.0)
                {
                    this.diningDollars = 0.0;
                }
                else
                {
                    this.diningDollars = value;
                }
            }
        }
        public string SocialSecurityNum
        {
            get { return this.socialSecurityNum.Substring(this.socialSecurityNum.Length - 4, 4); }
            //set { this.socialSecurityNum = value; }
        }

        //Constructors
        //Constructors may not have the same number of params which are in the same order and same type.
        public Student(string aStudentId, string aFirstName, string aLastName, string anAddress, string aCity, string aState, string aZipCode, double DiningDollars, string aSocialSecurityNum)
        {
            //There is no set for studentId or socialSecurityNum, use lowercase var
            /*this.studentId = aStudentId;
            this.FirstName = aFirstName;
            this.LastName = aLastName;
            this.Address = anAddress;
            this.City = aCity;
            this.State = aState;
            this.ZipCode = aZipCode;
            this.DiningDollars = DiningDollars;
            this.socialSecurityNum = aSocialSecurityNum;*/
        }
        public Student() : this("n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", 0.0, "123456789")
        {
            //Empty constructor
        }
        public Student(string aStudentId, string aFirstName, string aLastName, double DiningDollars) :
            this(aStudentId, aFirstName, aLastName, "n/a", "n/a", "n/a", "n/a", DiningDollars, "123456789")
        {
            /*this.studentId = aStudentId;
            this.FirstName = aFirstName;
            this.LastName = aLastName;
            this.DiningDollars = DiningDollars;*/
        }

        //Chaining constructors

        //Methods
        public override string AddClass()
        {
            return "The student will take a class.";
        }
        public override string ToString()
        {
            string message = "";
            message = message + "StudentId: " + this.StudentId + "\n";
            message = message + "FirstName: " + this.FirstName + "\n";
            message = message + "LastName: " + this.LastName + "\n";
            message = message + "Address: " + this.Address + "\n";
            message = message + "City: " + this.City + "\n";
            message = message + "State: " + this.State + "\n";
            message = message + "ZipCode: " + this.ZipCode + "\n";
            message = message + "DiningDollars: " + this.DiningDollars + "\n";
            message = message + "Social Security Number: " + this.SocialSecurityNum + "\n";
            return message;
        }

        public override string DropClass()
        {
            throw new NotImplementedException();
        }
    }

}
