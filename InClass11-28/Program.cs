// Written by Rogan Helm
// 11/28/22
using InClass11_28;
using System.Linq.Expressions;

Product milk = new Product(1, 2, "Milk");
Product ham = new Product(2, 3, "Ham");
Product bread = new Product(3, 2, "Bread");
Product aPetCat = new Product(4, 100, "Cat");
ProductCatalog Catalog = new ProductCatalog();

Catalog.AddProduct(milk);
Catalog.AddProduct(ham);
Catalog.AddProduct(bread);
Catalog.AddProduct(aPetCat);

Console.WriteLine(Catalog.ToString());
Console.Write("Choose an item you would like to buy (enter ID 1-4): ");

int input = Console.Read();

try
{
    if (input == 1)
    {
        Console.WriteLine(milk);
    }
    else if (input == 2)
    {
        Console.WriteLine(ham);
    }
    else if (input == 3)
    {
        Console.WriteLine(bread);
    }
    else if (input == 4)
    {
        Console.WriteLine(aPetCat);
    }
}
catch
{
    throw new ArgumentOutOfRangeException("Please enter valid ID");
}
finally
{
    if (input == 1)
    {
        Console.WriteLine(milk);
    }
    else if (input == 2)
    {
        Console.WriteLine(ham);
    }
    else if (input == 3)
    {
        Console.WriteLine(bread);
    }
    else if (input == 4)
    {
        Console.WriteLine(aPetCat);
    }
}
