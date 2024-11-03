internal class Program
{
    private static void Main(string[] args)
    {
        string[] expression = Console.ReadLine().Split(" ");

        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < expression.Length; i+=2)
        {
            int number;
            if (i != 0)
            {
                number = int.Parse(expression[i-1] + expression[i]);
            }
            else
            {
                number = int.Parse(expression[i]);
            }

            stack.Push(number);
        }

        Console.WriteLine(stack.Sum());
    }
}