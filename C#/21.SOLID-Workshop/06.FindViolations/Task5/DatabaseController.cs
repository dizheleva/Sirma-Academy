namespace _06.FindViolations.Task5
{
    public class DatabaseController
    {
        public void SaveToDatabase(Employee employee)
        {
            Console.WriteLine($"Saving {employee.Name} data to database...");
        }
    }
}
