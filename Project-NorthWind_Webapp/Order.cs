namespace Project_NorthWind_Webapp
{
    public class Order
    {
        //Class variables
        private int orderId = -1;
        private string customerId = "n/a";
        private int employeeId = -1;
        /*        private DateOnly orderDate = ?;
                private DateOnly requiredDate = ?;
                private DateOnly shippedDate = ?;*/
        private int shipVia = -1;
        private double freight = double.MaxValue;
        private string shipName = "n/a";
        private string shipAddress = "n/a";
        private string shipCity = "n/a";
        private string shipRegion = "n/a";
        private string shipPostalCode = "n/a";
        private string shipCountry = "n/a";

        //Gets and sets
        public int OrderId
        {
            get { return this.orderId; }
            set
            {
                if (value > -1) { this.orderId = value; }
                else { this.orderId = 0; }
            }
        }
        public string CustomerId
        {
            get { return this.customerId; }
            set { this.customerId = value; }
        }
        public int EmployeeId
        {
            get { return this.employeeId; }
            set
            {
                if (value > -1) { this.employeeId = value; }
                else { this.employeeId = 0; }
            }
        }
        //dates are supposed to go here
        public int ShipVia
        {
            get { return this.shipVia; }
            set
            {
                if (value > -1) { this.shipVia = value; }
                else { this.shipVia = 0; }
            }
        }
        public double Freight
        {
            get { return this.freight; }
            set
            {
                if (value > 0.0) { this.freight = value; }
                else { this.freight = 0.1; }
            }
        }
        public string ShipName
        {
            get { return this.shipName; }
            set { this.shipName = value; }
        }
        public string ShipAddress
        {
            get { return this.shipAddress; }
            set { this.shipAddress = value; }
        }
        public string ShipCity
        {
            get { return this.shipCity; }
            set { this.shipCity = value; }
        }
        public string ShipRegion
        {
            get { return this.shipRegion; }
            set { this.shipRegion = value; }
        }
        public string ShipPostalCode
        {
            get { return this.shipPostalCode; }
            set { this.shipPostalCode = value; }
        }
        public string ShipCountry
        {
            get { return this.shipCountry; }
            set { this.shipCountry = value; }
        }
        //Methods
        public override string ToString()
        {
            string message = "";
            message = message + "Order ID: " + this.OrderId + "\n";
            message = message + "Customer ID: " + this.CustomerId + "\n";
            message = message + "Employee ID: " + this.EmployeeId + "\n";
            message = message + "Ship Via: " + this.ShipVia + "\n";
            message = message + "Freight: " + this.Freight + "\n";
            message = message + "Ship Name: " + this.ShipName + "\n";
            message = message + "Ship Address: " + this.ShipAddress + "\n";
            message = message + "Ship City: " + this.ShipCity + "\n";
            message = message + "Ship Region: " + this.ShipRegion + "\n";
            message = message + "Ship Postal Code: " + this.ShipPostalCode + "\n";
            message = message + "Ship Country: " + this.ShipCountry + "\n";
            return message;
        }
        public Order()
        {
            //Empty constructor
        }
        public Order(int orderId, string customerId, int employeeId, int shipVia, double freight, string shipName, string shipAddress, string shipCity, string shipRegion, string shipPostalCode, string shipCountry)
        {
            OrderId = orderId;
            CustomerId = customerId;
            EmployeeId = employeeId;
            ShipVia = shipVia;
            Freight = freight;
            ShipName = shipName;
            ShipAddress = shipAddress;
            ShipCity = shipCity;
            ShipRegion = shipRegion;
            ShipPostalCode = shipPostalCode;
            ShipCountry = shipCountry;
        }
    }
}
