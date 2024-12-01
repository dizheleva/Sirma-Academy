namespace InventoryManagmentSystem.Models.Interfaces
{
    public interface IItem
    {
        string GetDetails();
        decimal CalculateValue();
        void DisplayDescription();
    }
}
