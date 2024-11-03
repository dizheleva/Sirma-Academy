internal class Program
{
    private static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        
        Stack<int> stack = new Stack<int>();
        foreach (int number in numbers)
        {
            stack.Push(number);
        }

        while (stack.Count > 0)
        {
            Console.Write(stack.Pop() + " ");
        }
    }
}