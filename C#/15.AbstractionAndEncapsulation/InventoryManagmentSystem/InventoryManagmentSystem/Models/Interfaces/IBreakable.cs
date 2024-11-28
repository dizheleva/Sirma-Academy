namespace InventoryManagmentSystem.Models.Interfaces
{
    public interface IBreakable
    {
        bool IsBreakable();
        void HandleBreakage();
    }
}
