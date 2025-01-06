namespace _06.FindViolations.Task4
{
    public class ShoppingCart
    {
        private SqlDatabase _database;
        // Dependancy inversion => not to depend on concrete database
        public ShoppingCart(SqlDatabase database)
        {
            _database = database;
        }
        public void AddItem(string item)
        {
            _database.SaveItem(item);
        }
    }
}
