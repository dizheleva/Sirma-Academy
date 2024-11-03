using System.Collections;
using System.Collections.Specialized;
internal class Program
{
    private static void Main(string[] args)
    {
        OrderedDictionary plates = [];

        int commandsCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < commandsCount; i++)
        {
            string[] command = Console.ReadLine().Split();

            string action = command[0];
            string userName = command[1];

            if (action == "Register")
            {
                string plateNymber = command[2];

                if (plates.Contains(userName))
                {
                    Console.WriteLine($"ERROR: already registered with plate number {plates[userName]}");
                }
                else
                {
                    plates[userName] = plateNymber;
                    Console.WriteLine($"{userName} registered {plateNymber} successfully.");
                }
            }
            else if (action == "Unregister")
            {
                if (plates.Contains(userName))
                {
                    plates.Remove(userName);
                    Console.WriteLine($"{userName} unregistered successfully.");
                }
                else
                {
                    Console.WriteLine($"ERROR: user {userName} not found");
                }
            }
        }

        foreach (DictionaryEntry plate in plates)
        {
            Console.WriteLine($"{plate.Key} => {plate.Value}");
        }
    }
}