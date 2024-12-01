namespace InventoryManagmentSystem.Models
{
    using System.Text;
    using InventoryManagmentSystem.Models.Enums;

    public class FragileItem : InventoryItem
    {
        public FragileItem(string id, string name, string description, decimal price, int quantity, double weight)
            : base(SetCategory(category), id, name, description, price, quantity)
        {
            Weight = weight;
        }
        private const Category category = Category.Fragile;
        public double Weight { get; set; }
        public override decimal CalculateValue() => base.CalculateValue() * Quantity;

        public override string GetDetails()
        {
            var result = new StringBuilder();
            result.AppendLine($"Kg per piece: {Weight:F2}");
            result.AppendLine($"Total Value: {CalculateValue():F2}");
            result.AppendLine($"Item ID: {Id}\n");

            return base.GetDetails() + result;
        }

        public override string HandleBreakage()
        {            
            Quantity--;
            return base.HandleBreakage() + $"\nRemaining Quantity: {Quantity}";
        }
    }
}
