namespace InventoryManagmentSystem
{
    using System.Collections.Generic;
    using InventoryManagmentSystem.JsonIOManager;
    using InventoryManagmentSystem.Models;

    internal class Inventory
    {
        public static List<InventoryItem> Items { get; set; } = IOManager.LoadData();

        public static void SaveChanges()
        {
            IOManager.SaveData(Items);
        }
    }
}
