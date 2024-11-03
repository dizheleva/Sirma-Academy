internal class Program
{
    private static void Main(string[] args)
    {
        decimal number = decimal.Parse(Console.ReadLine());

        Stack<int> stack = new Stack<int>();

        if (number == 0)
        {
            Console.WriteLine(0);
            return;
        }

        while (number >= 1)
        {
            stack.Push((int)(number % 2));
            number /= 2;
        }

        while (stack.Count > 0)
        {
            Console.Write(stack.Pop() + " ");
        }        
    }
}