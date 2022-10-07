// Written by Rogan Helm
// 10/7/22

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWebApp.Models
{
    public sealed class Professor : Person
    {
        private string techId = "n/a";
        private string firstName = "n/a";
        private string lastName = "n/a";

        private List<Student> avisees = new List<Student>();

        //Gets and sets
        public string TechId { get { return this.techId; } set { this.techId = value; } }
        public string FirstName { get { return this.firstName; } set { this.firstName = value; } }
        public string LastName { get { return this.lastName; } set { this.lastName = value; } }
        public List<Student> Avisees { get { return this.avisees; } set { this.avisees = value; } }

        //Methods
        public void AddAdvisee(Student aStudent)
        {
            if (aStudent != null)
            {
                this.Avisees.Add(aStudent);
            }
        }
        public override string AddClass()
        {
            return "The professor will teach a class.";
        }
        public override string DropClass()
        {
            return "The student will drop a class.";
        }
        public override string ToString()
        {
            string message = "";
            message = message + "TechID: " + this.TechId + "\n"; //Always use capitolized version if you can, especially since this is a read-only property
            message = message + "First Name: " + this.FirstName + "\n";
            message = message + "Last Name: " + this.LastName + "\n";
            foreach (var s in this.Avisees) { message = message + s.ToString() + "\n"; }
            return base.ToString();
        }
    }
}
