namespace _05.ClassStorage
{    public class Product(string name, decimal price, int quantity)
    {
        public string Name { get; set; } = name;
        public decimal Price { get; set; } = price;
        public int Quantity { get; set; } = quantity;
    }
}
