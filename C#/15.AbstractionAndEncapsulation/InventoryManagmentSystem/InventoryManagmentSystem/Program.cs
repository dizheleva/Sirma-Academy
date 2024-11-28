using InventoryManagmentSystem.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        List<InventoryItem> inventoryList = [];

        ElectronicsItem laptop1 = new ElectronicsItem("A01", 1, "Lenovo X1", "X1 Carbon", 1289);
        ElectronicsItem laptop2 = new ElectronicsItem("A02", 2, "Lenovo Yoga", "X1 Yoga", 1029);
        Console.WriteLine(laptop2.CalculateValue());

        GroceryItem potatoes = new GroceryItem("G89", 2, "Potato", "Canadian", 3.45m, 10, DateTime.Now.AddDays(10));
        potatoes.HandleExpiration();

        FragileItem vase = new FragileItem("F58", 7, "Vase", "Made in China", 3.90m, 0.380);

        Console.WriteLine(vase.GetDetails());
        vase.IsBroken = true;
        vase.HandleBreakage();
        vase.DisplayDescription();
        Console.WriteLine(vase.Quantity);

        Console.WriteLine(laptop1.GetDetails());
        Console.WriteLine(potatoes.GetDetails());
    }
}