namespace InventoryManagmentSystem.Models.Interfaces
{
    using Enums;

    public interface ICategorizable
    {
        Category GetCategory();
        static abstract Category SetCategory(Category category);
    }
}
