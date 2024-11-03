internal class Program
{
    private static void Main(string[] args)
    {
        string expression = Console.ReadLine();
        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < expression.Length; i++)
        {
            char ch = expression[i];

            if (ch == '(')
            {
                stack.Push(i);
            }

            if (ch == ')')
            {
                int startIndex = stack.Pop();
                int endIndex = i - startIndex + 1;
                string substring = expression.Substring(startIndex, endIndex);
                Console.WriteLine(substring);
            }
        }
    }
}