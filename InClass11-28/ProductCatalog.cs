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
        public ProductCatalog(string aName)
        {
            Product aProduct = new Product();
            Products.Add(aProduct);
        }

        public void AddProduct(Product aProduct)
        {
            this.products.Add(aProduct);
        }
    }
}
