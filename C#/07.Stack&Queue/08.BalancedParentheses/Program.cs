internal class Program
{
    private static void Main(string[] args)
    {
        string input = Console.ReadLine();

        Stack<char> stackOfParentheses = new Stack<char>();

        char[] openParentheses = { '(', '{', '[' };

        bool isValid = true;

        foreach (char ch in input)
        {
            if (openParentheses.Contains(ch))
            {
                stackOfParentheses.Push(ch);
            }

            if (stackOfParentheses.Count > 0)
            {
                if (stackOfParentheses.Peek() == '(' && ch == ')')
                {
                    stackOfParentheses.Pop();
                }
                else if (stackOfParentheses.Peek() == '{' && ch == '}')
                {
                    stackOfParentheses.Pop();
                }
                else if (stackOfParentheses.Peek() == '[' && ch == ']')
                {
                    stackOfParentheses.Pop();
                }
            }
            else
            {
                isValid = false;
                break;
            }

        }

        if (stackOfParentheses.Count > 0)
        {
            isValid = false;
        }

        Console.WriteLine(isValid);
    }
}