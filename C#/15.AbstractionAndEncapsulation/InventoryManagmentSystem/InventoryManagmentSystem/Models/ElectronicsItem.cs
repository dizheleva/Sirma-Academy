namespace InventoryManagmentSystem.Models
{
    using InventoryManagmentSystem.Models.Enums;

    public class ElectronicsItem(string id, int quantity, string name, string description, decimal price) 
        : InventoryItem(id, quantity, name, SetCategory(category), description, price)
    {
        private const Category category = Category.Electronics;
        public override decimal CalculateValue() => base.CalculateValue() * Quantity;
        public override void HandleBreakage()
        {
            base.HandleBreakage();
            Quantity--;
            Console.WriteLine($"Remaining Quantity: {Quantity}");
        }
    }
}
