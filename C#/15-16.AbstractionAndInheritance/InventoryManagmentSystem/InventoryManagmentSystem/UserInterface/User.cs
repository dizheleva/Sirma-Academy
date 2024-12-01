namespace InventoryManagmentSystem.User
{
    using System.Collections.Generic;
    using InventoryManagmentSystem.Models;

    public class User
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public List<InventoryItem> Items { get; set; }
    }
}
