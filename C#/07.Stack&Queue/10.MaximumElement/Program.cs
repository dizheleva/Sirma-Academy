internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Stack<int> stack = new Stack<int>();

        while (n > 0)
        {
            string[] command = Console.ReadLine().Split(" ");

            switch (command[0])
            {
                case "1":
                    stack.Push(int.Parse(command[1]));
                    break;
                case "2":
                    stack.Pop();
                    break;
                case "3":
                    Console.WriteLine(stack.Max());
                    break;
                default:
                    Console.WriteLine("Invalid command!");
                    break;
            }

            n--;
        }
    }
}