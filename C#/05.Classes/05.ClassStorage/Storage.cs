namespace _05.ClassStorage
{
    using System.Text.Json;

    public class Storage
    {
        public int Capacity { get; set; }
        public List<Product> StorageList { get; set; } = [];
        public decimal TotalCost { get => StorageList.Select(product => product.Quantity * product.Price).Sum(); }

        public Storage(int capacity) 
        {
            Capacity = capacity;
        }

        public void AddProduct(Product product) 
        {
            if (product.Quantity <= Capacity)
            {
                StorageList.Add(product);
                Capacity -= product.Quantity;
            }
        } 

        public void GetProducts() => StorageList.ForEach(product => Console.WriteLine(JsonSerializer.Serialize(product)));
    }
}
