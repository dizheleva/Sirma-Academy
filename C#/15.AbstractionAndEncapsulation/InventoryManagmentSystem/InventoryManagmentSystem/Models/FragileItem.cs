namespace InventoryManagmentSystem.Models
{
    using InventoryManagmentSystem.Models.Enums;

    public class FragileItem(string id, int quantity, string name, string description, decimal price, double weight) 
        : InventoryItem(id, quantity, name, SetCategory(category), description, price)
    {
        private const Category category = Category.Fragile;
        public double Weight { get; set; } = weight;
        public override decimal CalculateValue() => base.CalculateValue() * Quantity;
        public override void HandleBreakage()
        {
            base.HandleBreakage();
            Quantity--;
            Console.WriteLine($"Remaining Quantity: {Quantity}");
        }
    }
}
