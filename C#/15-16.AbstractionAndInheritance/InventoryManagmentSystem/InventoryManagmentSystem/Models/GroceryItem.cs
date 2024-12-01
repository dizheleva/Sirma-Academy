namespace InventoryManagmentSystem.Models
{
    using System.Text;
    using InventoryManagmentSystem.Models.Enums;

    public class GroceryItem : InventoryItem
    {
        public GroceryItem(string id, string name, string description, decimal price, int quantity, double weight, DateTime expirationDate)
            : base (SetCategory(category), id, name, description, price, quantity)
        {
            Weight = weight;
            ExpirationDate = expirationDate;
        }

        private const Category category = Category.Grocery;
        public double Weight { get; set; }
        public DateTime ExpirationDate { get; set; }

        public override decimal CalculateValue() => base.CalculateValue() * Quantity * (decimal)Weight;

        public override string GetDetails()
        {
            var result = new StringBuilder();
            result.AppendLine($"Kg per piece: {Weight:F2}");
            result.AppendLine($"Total Value: {CalculateValue():F2}");
            result.AppendLine($"Expiration date: {ExpirationDate.ToString("MM/dd/yyyy")}");
            result.AppendLine($"Item ID: {Id}");

            return base.GetDetails() + result;
        }

        public override string HandleExpiration()
        {
            if (ExpirationDate == DateTime.Now)
            {
                var result = new StringBuilder();
                result.AppendLine($"\nExpired {Quantity} X {Weight:F2} kg of {Name}");                
                result.AppendLine($"Estimated loss: {CalculateValue():F2}");

                return base.HandleExpiration() + result;
            }

            return $"No expiration loss for item {Name}";
        }
    }
}
