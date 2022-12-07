using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass11_28
{
    public class ShoppingCart
    {
        private string products = "n/a";
        private int quantity = int.MaxValue;
        private float price = float.MaxValue;
        private float total = float.MaxValue;

        public string Products
        {
            get
            {
                return this.products;
            }
            set
            {
                this.products = value;
            }
        }

        public int Quantity
        {
            get
            {
                return this.quantity;
            }
            set
            {
                this.quantity = value;
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

        public float Total
        {
            get
            {
                return this.total;
            }
            set
            {
                this.total = value;
            }
        }

        public override string ToString()
        {
            string message = string.Empty;
            message = message + "Products: " + this.products + "\n";
            message = message + "Quantity: " + this.quantity + "\n";
            message = message + "Price: " + this.price + "\n";
            message = message + "Total: " + this.total + "\n";
            return message;
        }
    }
}
