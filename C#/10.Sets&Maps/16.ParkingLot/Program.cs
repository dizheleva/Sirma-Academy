internal class Program
{
    private static void Main(string[] args)
    {
        HashSet<string> plates = [];

        string command;

        while ((command = Console.ReadLine()) != "END")
        {
            string[] data = command.Split(", ");

            string action = data[0];
            string plate = data[1];

            switch (action)
            {
                case "IN":
                    plates.Add(plate);
                    break;
                case "OUT":
                    plates.Remove(plate);
                    break;
                default:
                    Console.WriteLine("ERROR!");
                    break;
            }
        }

        if (plates.Count == 0) 
        { 
            Console.WriteLine("Parking Lot is Empty"); 
        }

        foreach (string plate in plates)
        {
            Console.WriteLine($"{plate}");
        }
    }
}