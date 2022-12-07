using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass11_28
{
    public class Customer
    {
        private int id = int.MinValue;
        private string name = "n/a";

        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public override string ToString()
        {
            string message = string.Empty;
            message = message + "ID: " + this.id + "\n";
            message = message + "Name: " + this.name + "\n";
            return message;
        }
    }
}
