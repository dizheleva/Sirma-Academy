
internal class Program
{
    private static void Main(string[] args)
    {
        SortedDictionary<string, string> phoneBook = [];
        string command;

        while ((command = Console.ReadLine()) != "search")
        {            
            UpdatePhoneBook(phoneBook, command);
        }

        while ((command = Console.ReadLine()) != "stop")
        {
            if (command.Contains('-'))
            {
                UpdatePhoneBook(phoneBook, command);
            }
            else
            {
                if (phoneBook.Any(x => x.Key == command))
                {
                    Console.WriteLine($"{command} -> {phoneBook[command]}");
                }
                else
                {
                    Console.WriteLine($"Contact {command} not found.");
                }
            }            
        }
    }

    private static void UpdatePhoneBook(SortedDictionary<string, string> phoneBook, string data)
    {
        var name = data.Substring(0, data.IndexOf('-'));
        var phone = data.Substring(data.IndexOf("-") + 1);

        if (!phoneBook.ContainsKey(name))
        {
            phoneBook.Add(name, string.Empty);
        }

        phoneBook[name] = phone;
    }
}