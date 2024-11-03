internal class Program
{
    private static void Main(string[] args)
    {
        HashSet<string> usernames = [];
        int entries = int.Parse(Console.ReadLine());

        for (int i = 0; i < entries; i++)
        {
            string username = Console.ReadLine();
            usernames.Add(username);
        }

        foreach (var username in usernames)
        {
            Console.WriteLine(username);
        }
    }
}