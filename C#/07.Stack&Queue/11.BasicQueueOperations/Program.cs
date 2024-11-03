internal class Program
{
    private static void Main(string[] args)
    {
        int[] inputArgs = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        int n = inputArgs[0];
        int s = inputArgs[1];
        int x = inputArgs[2];

        int[] numbersArr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        Queue<int> queue = new Queue<int>();

        for (int i = 0; i < n; i++)
        {
            queue.Enqueue(numbersArr[i]);
        }

        for (int i = 0; i < s; i++)
        {
            queue.Dequeue();
        }

        if (queue.Count == 0)
        {
            Console.WriteLine(queue.Count);
            return;
        }

        if (queue.Contains(x))
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine(queue.Min());
        }
    }
}