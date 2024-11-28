namespace InventoryManagmentSystem.Models
{
    using InventoryManagmentSystem.Models.Enums;

    public class ElectronicsItem(string id, int quantity, string name, string description, decimal price) 
        : InventoryItem(id, quantity, name, SetCategory(category), description, price)
    {
        private const Category category = Category.Electronics;
        public bool IsBroken { get; set; } = false;
        public override decimal CalculateValue() => base.CalculateValue() * Quantity;
        public override void HandleBreakage()
        {
            if (IsBroken)
            {
                base.HandleBreakage();
                Quantity--;
                Console.WriteLine($"Remaining Quantity: {Quantity}");
            }
            else
            {
                Console.WriteLine($"No breakage loss for item {Name}");
            }
        }
    }
}
