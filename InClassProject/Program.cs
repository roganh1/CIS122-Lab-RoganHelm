namespace InClassProject
{
    public class Problem
    {
        public static void Main()
        {
            FileGateway aGateway = new FileGateway();

            List<Product> myProducts = new List<Product>();
            myProducts = aGateway.GetProducts("C:\\Users\\wacky\\Downloads\\Products1.csv");

            foreach (var p in myProducts)
            {
                Console.WriteLine(p.ToString());
            }

            Console.WriteLine("\n\nProducts over 10.00");

            foreach (var p in myProducts)
            {
                if (p.UnitPrice > 10.00)
                {
                    Console.WriteLine(p.ToString());
                }

                var itemsOverTenDollars = from s in myProducts
                                          where s.UnitPrice > 10
                                          orderby s.UnitPrice descending
                                          select s.ProductName;
                var onlyItemsFromSupplier1 = from i in myProducts
                                             where i.SupplierId == 1
                                             select i;

                foreach(var n in itemsOverTenDollars)
                {
                    Console.WriteLine(n.ToString() + "/n");
                }
            }
        }
    }
}
