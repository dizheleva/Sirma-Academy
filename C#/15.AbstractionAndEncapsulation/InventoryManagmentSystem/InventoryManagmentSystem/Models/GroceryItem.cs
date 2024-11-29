namespace InventoryManagmentSystem.Models
{
    using InventoryManagmentSystem.Models.Enums;

    public class GroceryItem(string id, int quantity, string name, string description, decimal price, double weight, DateTime expirationDate) 
        : InventoryItem(id, quantity, name, SetCategory(category), description, price)
    {
        private const Category category = Category.Grocery;
        public double Weight { get; set; } = weight;
        public string ExpirationDate { get; set; } = expirationDate.ToString("MM/dd/yyyy");

        public override decimal CalculateValue() => base.CalculateValue() * Quantity * (decimal)Weight;
        public override string GetDetails()
        {
            return base.GetDetails() + $"\nExpiration date: {ExpirationDate}";
        }

        public override void HandleExpiration()
        {
            if (expirationDate == DateTime.Now)
            {
                base.HandleExpiration();
                Quantity--;
                Console.WriteLine($"Estimated loss: {(GetPrice() * (decimal)Weight):F2}");
                Console.WriteLine($"Remaining {Quantity} X {Weight:F2} kg");
            }
            else
            {
                Console.WriteLine($"No expiration loss for item {Name}");
            }
        }
    }
}
