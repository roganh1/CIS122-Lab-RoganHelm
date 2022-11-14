namespace InClassProject
{
    public class Product
    {
        private int productId = int.MaxValue;
        private string productName = "n/a";
        private double unitPrice = double.MaxValue;
        private int categoryId = int.MaxValue;
        private int supplierId = int.MaxValue;

        public int ProductId
        {
            get { return this.productId; }
            set { this.productId = value; }
        }

        public string ProductName
        {
            get { return this.productName; }
            set { this.productName = value; }
        }

        public double UnitPrice
        {
            get { return this.unitPrice; }
            set { this.unitPrice = value; }
        }

        public int CategoryId
        {
            get { return this.categoryId; }
            set { this.categoryId = value; }
        }

        public int SupplierId
        {
            get { return this.supplierId; }
            set { this.supplierId = value; }
        }

        public Product() : this(0, "none", 0, 0, Double.MaxValue) { }

        public Product(int aProductId, string aProductName, int aCategoryId, int aSupplierId, double aUnitPrice)
        {
            this.ProductId = aProductId;
            this.ProductName = aProductName;
            this.CategoryId = aCategoryId;
            this.SupplierId = aSupplierId;
            this.UnitPrice = aUnitPrice;
        }

        public override string ToString()
        {
            string message = "";
            message = message + "ProductId: " + this.ProductId + "\n";
            message = message + "ProductName: " + this.ProductName + "\n";
            message = message + "CategoryId: " + this.CategoryId + "\n";
            message = message + "SupplierId: " + this.SupplierId + "\n";
            message = message + "UnitPrice: " + this.UnitPrice + "\n";
            return message;
        }
    }
}
