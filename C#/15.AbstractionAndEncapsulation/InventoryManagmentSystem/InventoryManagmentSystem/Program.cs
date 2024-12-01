using System.Diagnostics;
using System.Xml.Linq;
using InventoryManagmentSystem;
using InventoryManagmentSystem.Models;
using InventoryManagmentSystem.Models.Enums;
using InventoryManagmentSystem.UserInterface;

internal class Program
{
    private static void Main(string[] args)
    {
        //var cucumber = new GroceryItem("G99", "Cucumber", "Serbian cucumber", 3.50m, 15, 7.5, new DateTime(2024, 12, 12));
        //Console.WriteLine(cucumber.HandleExpiration());

        //var arguments = new object[] { category, itemID, name, description, price, quantity };
        //arguments = (Object[])arguments.Concat(new object[] { weight }).ToArray();
        //var item = (InventoryItem)Activator.CreateInstance(Menu.GetItemType(Category.Electronics), new object[] { "E57", "Smartphone Samsung", "Samsung Galaxy A74", 778.96m, 4 });
        //Console.WriteLine(item.GetDetails());

        //Inventory.Items.Add(item2);
        //Inventory.SaveChanges();
        Menu.RunMenu();
        //List<InventoryItem> inventoryList = [];

        //ElectronicsItem laptop1 = new ElectronicsItem("A01", 1, "Lenovo X1", "X1 Carbon", 1289);
        //ElectronicsItem laptop2 = new ElectronicsItem("A02", 2, "Lenovo Yoga", "X1 Yoga", 1029);
        //Console.WriteLine(laptop2.CalculateValue());

        //GroceryItem potatoes = new GroceryItem("G89", 2, "Potato", "Canadian", 3.45m, 10, DateTime.Now.AddDays(10));
        //potatoes.HandleExpiration();

        //FragileItem vase = new FragileItem("F58", 7, "Vase", "Made in China", 3.90m, 0.380);

        //Console.WriteLine(vase.GetDetails());
        //vase.HandleBreakage();
        //vase.DisplayDescription();
        //Console.WriteLine(vase.Quantity);

        //Console.WriteLine(laptop1.GetDetails());
        //Console.WriteLine(potatoes.GetDetails());

        //var jsonLaptop = JsonSerializer.Serialize(laptop1);
        //Console.WriteLine(jsonLaptop);

        //var jsonPotato = JsonSerializer.Serialize(potatoes);
        //Console.WriteLine(jsonPotato);

        //var jsonVase = JsonSerializer.Serialize(vase);
        //Console.WriteLine(jsonVase);


        //inventoryList.Add(laptop1);
        //inventoryList.Add(laptop2);
        //inventoryList.Add(potatoes);
        //inventoryList.Add(vase);

        //string folderName = "Dataset";
        //string fileName = "data.json";
        //var mapper = new IOManager();
        //mapper.SaveData(inventoryList);
    }
}