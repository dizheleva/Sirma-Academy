namespace InventoryManagmentSystem.Models
{
    using System.Text;
    using InventoryManagmentSystem.Models.Enums;

    public class ElectronicsItem : InventoryItem
    {
        public ElectronicsItem(string id, string name, string description, decimal price, int quantity)
            : base (SetCategory(category), id, name, description, price, quantity)
        {
            
        }

        private const Category category = Category.Electronics;
        public override decimal CalculateValue() => base.CalculateValue() * Quantity;

        public override string GetDetails()
        {
            var result = new StringBuilder();
            result.AppendLine($"Total Value: {CalculateValue():F2}");
            result.AppendLine($"Item ID: {Id}");

            return base.GetDetails() + result;
        }

        public override string HandleBreakage()
        {            
            Quantity--;
            return base.HandleBreakage() + $"\nRemaining Quantity: {Quantity}";
        }
    }
}
