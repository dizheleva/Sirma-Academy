internal class Program
{
    private static void Main(string[] args)
    {
        int[] inputArgs = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        int n = inputArgs[0];
        int s = inputArgs[1];
        int x = inputArgs[2];

        int[] numbersArr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < n; i++)
        {
            stack.Push(numbersArr[i]);
        }

        for (int i = 0; i < s; i++)
        {
            stack.Pop();
        }

        if (stack.Count == 0)
        {
            Console.WriteLine(stack.Count);
            return;
        }

        if (stack.Contains(x))
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine(stack.Min());
        }
    }
}