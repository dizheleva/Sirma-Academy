using _05.ClassStorage;
using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        var productOne = new Product("cucumber", 1.50m, 15);
        var productTwo = new Product("tomato", 0.90m, 25);
        var productThree = new Product("bread", 1.10m, 8);
        var storage = new Storage(50);
        storage.AddProduct(productOne);
        storage.AddProduct(productTwo);
        storage.AddProduct(productThree);

        storage.GetProducts();
        Console.WriteLine(storage.Capacity);
        Console.WriteLine(storage.TotalCost);        
    }
}