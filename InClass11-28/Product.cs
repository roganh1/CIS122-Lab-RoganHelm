using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass11_28
{
    public class Product
    {
        private int id = int.MinValue;
        private float price = float.MaxValue;
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
        public float Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
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

        public Product() : this(0, 0, "none") { } // Empty constructor
        public Product(int anId, float aPrice, string aName)
        {
            this.id = anId;
            this.price = aPrice;
            this.name = aName;
        }

        public override string ToString()
        {
            string message = string.Empty;
            message = message + "ID: " + this.id + "\n";
            message = message + "Price: " + this.price + "\n";
            message = message + "Name: " + this.name + "\n";
            return message;
        }
    }
}
