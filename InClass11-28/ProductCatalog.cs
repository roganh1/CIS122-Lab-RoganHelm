using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass11_28
{
    public class ProductCatalog
    {
        private List<Product> products = new List<Product>();

        public List<Product> Products
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

        public ProductCatalog() { }
        public ProductCatalog(Product aProduct)
        {
            Products.Add(aProduct);
        }

        public void AddProduct(Product aProduct)
        {
            Products.Add(aProduct);
        }

        public override string ToString()
        {
            string message = string.Empty;
            message = message + Products + "/n";
            return message;
        }
    }
}
