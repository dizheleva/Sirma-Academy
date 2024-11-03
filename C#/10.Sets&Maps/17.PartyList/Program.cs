internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string, string> guests = [];

        string input;

        while ((input = Console.ReadLine()) != "PARTY")
        {
            bool isLengthCorrect = input.Length == 8;
            string guestStatus = Char.IsDigit(input[0]) ? "VIP" : "regular";

            if (!guests.ContainsKey(input) && isLengthCorrect)
            {
                guests.Add(input, guestStatus);
            }
        }

        while ((input = Console.ReadLine()) != "END")
        {
            if (guests.ContainsKey(input))
            {
                guests.Remove(input);
            }
        }

        Console.WriteLine(guests.Count());

        foreach (var guest in guests.OrderByDescending(g => g.Value == "VIP").ThenBy(a => a.Key))
        {
            Console.WriteLine(guest.Key);
        }
    }
}