namespace Project_NorthWind_Webapp
{
    public class Product
    {
        //Class variables
        private int productId = -1;
        private string productName = "n/a";
        private int supplierId = -1;
        private int categoryId = -1;
        private string quantityPerUnit = "n/a";
        private double unitPrice = double.MaxValue;
        private int unitsInStock = -1;
        private int unitsOnOrder = -1;
        private int reorderLevel = int.MaxValue;
        private bool discontinued = true;

        //Gets and sets
        public int ProductId
        {
            get { return productId; }
            set
            {
                if (value > -1) { productId = value; }
                else { productId = 0; }
            }
        }
        public string ProductName
        {
            get { return productName; }
            set { this.productName = value; }
        }
        public int SupplierId
        {
            get { return this.supplierId; }
            set
            {
                if (value > -1) { this.supplierId = value; }
                else { this.supplierId = 0; }
            }
        }
        public int CategoryId
        {
            get { return this.categoryId; }
            set
            {
                if (value > -1) { this.categoryId = value; }
                else { this.categoryId = 0; }
            }
        }
        public string QuantityPerUnit
        {
            get { return this.quantityPerUnit; }
            set { this.quantityPerUnit = value; }
        }
        public double UnitPrice
        {
            get { return this.unitPrice; }
            set
            {
                if (value > 0.0) { this.unitPrice = value; }
                else { this.unitPrice = 0.1; }
            }
        }
        public int UnitsInStock
        {
            get { return this.unitsInStock; }
            set
            {
                if (value > -1) { this.unitsInStock = value; }
                else { this.unitsInStock = 0; }
            }
        }
        public int UnitsOnOrder
        {
            get { return this.unitsOnOrder; }
            set
            {
                if (value > -1) { this.unitsOnOrder = value; }
                else { this.unitsOnOrder = 0; }
            }
        }
        public int ReorderLevel
        {
            get { return this.reorderLevel; }
            set
            {
                if (value > 0) { this.reorderLevel = value; }
                else { this.reorderLevel = 1; }
            }
        }
        public bool Discontinued { get; set; }
        //Methods
        public override string ToString()
        {
            string message = "";
            message = message + "Product ID: " + this.ProductId + "\n";
            message = message + "Product Name: " + this.ProductName + "\n";
            message = message + "Supplier ID: " + this.SupplierId + "\n";
            message = message + "Category ID: " + this.CategoryId + "\n";
            message = message + "Quantity per Unit: " + this.QuantityPerUnit + "\n";
            message = message + "Unit Price: " + this.UnitPrice + "\n";
            message = message + "Units in Stock: " + this.UnitsInStock + "\n";
            message = message + "Units on Order: " + this.UnitsOnOrder + "\n";
            message = message + "Reorder Level: " + this.ReorderLevel + "\n";
            message = message + "Discontinued: " + this.Discontinued + "\n";
            return message;
        }
        public Product()
        {
            //Empty constructor
        }
        public Product(int aProductId, string aProductName, int aSupplierId, int aCategoryId, string aQuantityPerUnit, double aUnitPrice, int unitsInStock, int unitsOnOrder, int reorderLevel, bool discontinued)
        {
            this.ProductId = aProductId;
            this.ProductName = aProductName;
            this.SupplierId = aSupplierId;
            this.CategoryId = aCategoryId;
            this.QuantityPerUnit = aQuantityPerUnit;
            this.UnitPrice = aUnitPrice;
            this.UnitsInStock = unitsInStock;
            this.UnitsOnOrder = unitsOnOrder;
            this.ReorderLevel = reorderLevel;
            this.Discontinued = discontinued;
        }
    }
}
