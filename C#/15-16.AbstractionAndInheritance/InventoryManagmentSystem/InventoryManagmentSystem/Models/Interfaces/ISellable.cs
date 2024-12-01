namespace InventoryManagmentSystem.Models.Interfaces
{
    public interface ISellable
    {
        decimal GetPrice();
        void SetPrice(decimal price);
    }
}
