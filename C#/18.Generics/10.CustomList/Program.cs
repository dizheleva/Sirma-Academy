using _10.CustomList;

internal class Program
{
    static void Main()
    {
        var customList = new CustomList<string>();

        string commandLine; 
        while ((commandLine = Console.ReadLine()) != "end")
        {
            var commandArgs = commandLine.Split();
            var command = commandArgs[0];

            switch (command)
            {
                case "Add":
                    customList.Add(commandArgs[1]);

                    break;

                case "Remove":
                    customList.Remove(int.Parse(commandArgs[1]));

                    break;

                case "Contains":
                    Console.WriteLine(customList.Contains(commandArgs[1]));

                    break;

                case "Swap":
                    customList.Swap(int.Parse(commandArgs[1]), int.Parse(commandArgs[2]));

                    break;

                case "Greater":
                    Console.WriteLine(customList.CountGreaterThan(commandArgs[1]));

                    break;

                case "Max":
                    Console.WriteLine(customList.GetMax());

                    break;

                case "Min":
                    Console.WriteLine(customList.GetMin());

                    break;

                case "Print":
                    Console.WriteLine(customList.ToString());

                    break;

                default:
                    Console.WriteLine("Invalid command!");

                    break;
            }
        }
    }
}