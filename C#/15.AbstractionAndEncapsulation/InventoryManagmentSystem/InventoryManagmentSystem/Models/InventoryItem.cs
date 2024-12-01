namespace InventoryManagmentSystem.Models
{
    using InventoryManagmentSystem.Models.Enums;

    public class InventoryItem : AbstractItem
    {
        private string id;
        private int quantity;

        public InventoryItem(Category category, string id, string name, string description, decimal price, int quantity) 
            : base(name, category, description, price)
        {
            Id = id;
            Quantity = quantity;
        }

        public string Id
        {
            get => id;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid Id!");
                }
                id = value;
            }
        }
        public int Quantity
        {
            get => quantity;
            set
            {
                if (quantity < 0)
                {
                    throw new ArgumentException("Invalid Quantity!");
                }
                quantity = value;
            }
        }

        public override string GetDetails() => base.GetDetails();
    }
}
