namespace InClassProject
{
    public class FileGateway
    {
        private Product aProduct;
        public List<Product> GetProducts(string aPath)
        {
            string[] allLines = File.ReadAllLines(aPath);
            string[] aRow;
            int index = 1;
            List<Product> aListOfProducts = new List<Product>();

            while (index < allLines.Length)
            {
                aProduct = new Product();
                aRow = allLines[index].Split(',');
                aProduct.ProductId = Convert.ToInt32(aRow[0]);
                aProduct.ProductName = aRow[1];
                aProduct.SupplierId = Convert.ToInt32(aRow[2]);
                aProduct.CategoryId = Convert.ToInt32(aRow[3]);
                aProduct.UnitPrice = Convert.ToDouble(aRow[5]);
                aListOfProducts.Add(aProduct);
                index++;
            }

            return aListOfProducts;
        }
    }
}
