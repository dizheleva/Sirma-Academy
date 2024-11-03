internal class Program
{
    private static void Main(string[] args)
    {
        string[] kids = Console.ReadLine().Split(" ");
        int tosses = int.Parse(Console.ReadLine());

        Queue<string> removedKids = new Queue<string>();

        string[] kidsInGame = new string[kids.Length - 1];

        bool isTossedFromStart = true;
        while (kids.Length > 1)
        {
            int kidIndex = isTossedFromStart ? tosses % kids.Length - 1 : tosses % kids.Length;
            if (kidIndex >= kids.Length - 1)
            {
                kidIndex = 0;
            }
            else if (kidIndex < 0)
            {
                kidIndex = kids.Length - 1;
            }

            isTossedFromStart = kidIndex == kids.Length - 1 || kidIndex == 0;

            string removedKid = kids[kidIndex];
            removedKids.Enqueue(removedKid);
            kids = Array.FindAll(kids, kid => kid != removedKid);            
        }

        while (removedKids.Count > 0)
        {
            Console.WriteLine($"Remove {removedKids.Dequeue()}");
        }

        Console.WriteLine($"Last is {kids[0]}");
    }
}