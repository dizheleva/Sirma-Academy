﻿namespace InventoryManagmentSystem.Models.Interfaces
{
    public interface IPerishable
    {
        bool IsPerishable();
        string HandleExpiration();
    }
}