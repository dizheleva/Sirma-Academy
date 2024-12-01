namespace InventoryManagmentSystem.UserInterface
{
    using System;
    using InventoryManagmentSystem.Models;
    using InventoryManagmentSystem.Models.Enums;

    public class Menu
    {
        public static void RunMenu()
        {
            while (true)
            {
                DisplayMenu();
                var choice = GetUserChoice();

                switch ((int)choice)
                {
                    case 1:
                        DisplayInventory();
                        break;

                    case 2:                        
                        AddItem();
                        break;

                    case 3:
                        RemoveItem();
                        break;

                    case 4:                        
                        UpdateItem();
                        break;

                    case 5:
                        Console.WriteLine("You Chose to Place Order.");
                        // Place Order logic here
                        PlaceOrder();
                        break;

                    case 6:
                        Console.Write("Are you sure you want to exit? (Y/N): ");

                        var confirmation = Console.ReadLine().ToUpper()[0];
                        Console.WriteLine();

                        if (confirmation == 'Y')
                        {
                            Console.WriteLine("Exiting...");
                            return; // Exit the Main method
                        }

                        Console.Clear();
                        continue;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;                        
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear(); // Clear the console for the next iteration
            }
        }

        private static void PlaceOrder() => throw new NotImplementedException();
        private static void UpdateItem()
        {
            Console.WriteLine("You Chose to Update Item.");

            var item = FindItem();
            if (item == null) { return; }

            Inventory.Items.Remove(item);

            Console.WriteLine("Update item options:\n");
            Console.Write("Enter new Price: ");
            decimal price = Convert.ToDecimal(Console.ReadLine());
            item.SetPrice(price);

            Console.Write("Enter new Quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            item.Quantity = quantity;

            Inventory.Items.Add(item);
            Inventory.SaveChanges();
            Console.WriteLine("Inventory List Updated!");
        }

        private static InventoryItem FindItem()
        {
            Console.Write("\nEnter Item ID: ");
            string id = Console.ReadLine();
            Console.WriteLine();

            var item = Inventory.Items.FirstOrDefault(i => i.Id == id);

            if (item == null)
            {
                Console.WriteLine("No Item Found!");
                return null;
            }

            Console.WriteLine("Item Chosen:");
            Console.WriteLine(item.GetDetails());

            return item;
        }

        private static void RemoveItem()
        {
            Console.WriteLine("You Chose to Remove Item.");

            var item = FindItem();
            if (item != null) { return; }

            Console.Write($"Are you sure you want to delete item {item.Name}? (Y/N): ");
            var confirmation = Console.ReadLine().ToUpper()[0];
            Console.WriteLine();

            if (confirmation != 'Y')
            {
                return; // Exit the Main method
            }

            Inventory.Items.Remove(item);
            Inventory.SaveChanges();
            Console.WriteLine("Item Removed From Inventory!");
        }

        private static void AddItem()
        {
            Console.WriteLine("You Chose to Add Item. Follow the steps:");

            DisplayCategories();
            Console.Write("Enter Category Selection: ");
            int categoryNumber = Convert.ToInt32(Console.ReadLine());
            Category category = (Category)categoryNumber;

            Console.Write("Enter ID: ");
            string itemID = Console.ReadLine();

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Description: ");
            string description = Console.ReadLine();

            Console.Write("Enter Price: ");
            decimal price = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter Quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            var arguments = new object[] { itemID, name, description, price, quantity };

            if (categoryNumber == 1 || categoryNumber == 2)
            {
                Console.Write("Enter Weight in kg per unit: ");
                double weight = Convert.ToDouble(Console.ReadLine());
                arguments = (Object[])arguments.Concat(new object[] { weight }).ToArray();
            }

            if (categoryNumber == 1)
            {
                Console.Write("Enter Expiration Date: ");
                DateTime date = Convert.ToDateTime(Console.ReadLine());
                arguments = (Object[])arguments.Concat(new object[] { date }).ToArray();
            }

            var type = GetItemType(category);
            var item = (InventoryItem)Activator.CreateInstance(type, arguments);

            Inventory.Items.Add(item);
            Inventory.SaveChanges();

            Console.WriteLine($"New item {item.Name} added to the inventory.");
        }

        private static void DisplayInventory()
        {
            Console.WriteLine("\n******** Inventory Items **********\n");

            foreach (var item in Inventory.Items)
            {
                Console.WriteLine(item.GetDetails());
                Console.WriteLine();
            }
        }

        private static MenuChoices GetUserChoice()
        {
            var input = Console.ReadLine();
            return Enum.TryParse(input, out MenuChoices choice)
                ? choice
                : 0;
        }

        private static string GetChoiceName(MenuChoices menuChoice)
        {
            return (int)menuChoice switch
            {
                1 => "Display Items List",
                2 => "Add New Item",
                3 => "Remove Item By ID",
                4 => "Update Item By ID",
                5 => "Place Order",
                6 => "Exit"
            };
        }

        private static void DisplayMenu()
        {
            Console.WriteLine("************ Main Menu ************");
            Console.WriteLine("Please choose an action:\n");

            foreach (MenuChoices choice in Enum.GetValues(typeof(MenuChoices)))
            {
                if (choice != 0)
                {
                    var name = GetChoiceName(choice);
                    Console.WriteLine($"    [{(int)choice}]:    {name}");
                }
            }

            Console.Write("\nEnter your selection: ");
        }

        private static void DisplayCategories()
        {
            Console.WriteLine("\nItem Categories:\n");

            foreach (Category category in Enum.GetValues(typeof(Category)))
            {
                if (category != 0)
                {
                    Console.WriteLine($"    [{(int)category}]:    {category}");
                }
            }
            Console.WriteLine();
        }

        public static Type GetItemType(Category category)
        {
            return category switch
            {
                Category.Grocery => typeof(GroceryItem),
                Category.Fragile => typeof(FragileItem),
                Category.Electronics => typeof(ElectronicsItem),
                _ => typeof(InventoryItem),
            };
        }
    }
}
