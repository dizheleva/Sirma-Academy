


internal class Program
{
    private static readonly Stack<string> done = new();
    private static readonly Stack<string> undone = new();
    private static void Main(string[] args)
    {
        string line;
        while ((line = Console.ReadLine()) != "End")
        {
            string command = line.Substring(0, line.IndexOf('('));

            switch (command)
            {
                case "Insert":
                    string input = line.Substring(line.IndexOf('"') + 1, line.Length - command.Length - 4);
                    Insert(input);
                    break;
                case "Undo":
                    Undo();                    
                    break;
                case "Redo":
                    Redo();
                    break;
                default:
                    break;
            }
        }
    }

    private static void Redo()
    {
        done.Push(undone.Pop());
        Console.WriteLine(string.Join("", done.ToArray().Reverse()));
    }

    private static void Undo()
    {
        undone.Push(done.Pop());
        Console.WriteLine(string.Join("", done.ToArray().Reverse()));
    }

    private static void Insert(string input)
    {
        done.Push(input);
        Console.WriteLine(string.Join("", done.ToArray().Reverse()));
    }
}