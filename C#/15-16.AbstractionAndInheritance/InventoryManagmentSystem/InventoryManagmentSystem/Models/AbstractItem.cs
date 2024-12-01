namespace InventoryManagmentSystem.Models
{
    using System.Text;
    using Enums;
    using Interfaces;

    public abstract class AbstractItem : IItem, ICategorizable, ISellable, IBreakable, IPerishable
    {
        private readonly int[] PerishableCategories = [1];
        private readonly int[] BreakableCategories = [2, 3];

        private string name;
        private readonly Category category;
        private readonly string description;
        private decimal price;
        private readonly bool isBreakable;
        private readonly bool isPerishable;

        public string Name
        {
            get => name;

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid Name!");
                }
                name = value;
            }
        }
        public Category Category
        {
            get => GetCategory();
            set => SetCategory(value);
        }

        public string Description
        {
            get => description;
        }

        public decimal Price
        {
            get => GetPrice();
            set => SetPrice(value);
        }

        public AbstractItem(string name, Category category, string description, decimal price)
        {
            Name = name;
            this.category = category;
            this.description = description;
            this.price = price;
            isBreakable = IsBreakable();
            isPerishable = IsPerishable();
        }

        public virtual string GetDetails()
        {
            var details = new StringBuilder();
            details.AppendLine("---------- Item ----------");
            details.AppendLine($"Name: {name}");
            details.AppendLine($"Category: {category}");
            details.AppendLine($"Description: {description}");
            details.AppendLine($"Price: {price}");
            details.Append($"Item is ");

            if (isBreakable)
            {
                details.AppendLine("breakable");
            }

            if (isPerishable)
            {
                details.AppendLine("perishable");
            }

            return details.ToString();
        }
        public virtual decimal CalculateValue() => price;
        public void DisplayDescription() => Console.WriteLine(description);
        public Category GetCategory() => category;
        public static Category SetCategory(Category category)
        {
            var categories = (Category[])Enum.GetValues(typeof(Category));

            if (!categories.Contains(category))
            {
                throw new ArgumentException("Invalid Category!");
            }
            return category;
        }

        public decimal GetPrice() => price;
        public void SetPrice(decimal price)
        {
            if (price < 0)
            {
                throw new ArgumentException("Invalid Price!");
            }

            this.price = price;
        }

        public bool IsBreakable()
        {
            var category = GetCategory();
            if (BreakableCategories.Contains((int)category))
            {
                return true;
            }

            return false;
        }
        public virtual string HandleBreakage()
        {
            if (isBreakable)
            {
                return $"A piece of item {Name} is broken.";
            }

            return $"Item {Name} can not be broken.";
        }

        public bool IsPerishable()
        {            
            var category = GetCategory();
            if (PerishableCategories.Contains((int)category))
            {
                return true;
            }

            return false;                       
        }
        public virtual string HandleExpiration()
        {
            if (isPerishable)
            {
               return $"Item {Name} expirated.";
            }

            return $"No expiration loss for item {Name}.";
        }
    }
}
