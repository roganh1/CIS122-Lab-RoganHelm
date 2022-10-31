// Written by Rogan Helm

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNorthwind
{
    internal class OrderDetail
    {
        //Class variables
        private int orderId = -1;
        private int productId = -1;
        private double unitPrice = double.MaxValue;
        private int quantity = 0;
        private double discount = 0.0;

        //Gets and sets
        public int OrderId
        {
            get { return this.OrderId; }
            set
            {
                if (value > -1)
                {
                    this.OrderId = value;
                }
                else
                {
                    this.OrderId = 0;
                }
            }
        }
        public int ProductId
        {
            get { return this.ProductId; }
            set
            {
                if (value > -1)
                {
                    this.ProductId = value;
                }
                else
                {
                    this.ProductId = 0;
                }
            }
        }
        public double UnitPrice
        {
            get { return this.UnitPrice; }
            set
            {
                if(value>0)
                {
                    this.UnitPrice = value;
                }
                else
                {
                    this.UnitPrice = 1;
                }
            }
        }
        public int Quantity
        {
            get { return this.Quantity; }
            set
            {
                if(value>0)
                {
                    this.Quantity = value;
                }
                else
                {
                    this.Quantity = 1;
                }
            }
        }
        public double Discount
        {
            get { return this.Discount; }
            set
            {
                if(value>0.0) { this.Discount = value; }
                else { this.Discount = 0.1; }
            }
        }
        //Methods
        public override string ToString()
        {
            string message = "";
            message = message + "Order ID: " + this.OrderId + "\n";
            message = message + "Product ID: " + this.ProductId + "\n";
            message = message + "Unit Price: " + this.UnitPrice + "\n";
            message = message + "Quantity: " + this.Quantity + "\n";
            message = message + "Discount: " + this.Discount + "\n";
            return message;
        }
        public OrderDetail()
        {
            //Empty constructor
        }
        public OrderDetail(int orderId, int productId, double unitPrice, int quantity, double discount)
        {
            OrderId = orderId;
            ProductId = productId;
            UnitPrice = unitPrice;
            Quantity = quantity;
            Discount = discount;
        }
    }
}
