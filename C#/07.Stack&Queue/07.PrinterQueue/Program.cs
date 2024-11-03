
internal class Program
{
    private static void Main(string[] args)
    {
        Queue<string> printer = new Queue<string>();

        string input;
        while ((input = Console.ReadLine()) != "print")
        {
            Offer(printer, input);            
        }

        PollFirst(printer);
    }

    private static void PollFirst(Queue<string> printer)
    {
        while (printer.Count > 0)
        {
            Console.WriteLine(printer.Dequeue());
        }
    }
    private static void Offer(Queue<string> printer, string fileName)
    {
        if (fileName == "cancel")
        {
            if (printer.Count == 0)
            {
                Console.WriteLine("Standby");
            }
            else
            {
                string canceled = printer.Dequeue();
                Console.WriteLine($"Canceled {canceled}");
            }
        }
        else
        {
            printer.Enqueue(fileName);
        }
    }
}