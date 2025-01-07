internal class Program
{
    private static void Main(string[] args)
    {
        var dbManager1 = Singleton.Singleton.Instance;
        var dbManager2 = Singleton.Singleton.Instance;

        if (dbManager1 == dbManager2)
        {
            Console.WriteLine("Singleton works, both variables contain the same instance.");
        }
        else
        {
            Console.WriteLine("Singleton failed, variables contain different instances.");
        }

        dbManager1.Connect();
        dbManager2.Connect();

        dbManager1.Disconnect();
    }
}