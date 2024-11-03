
internal class Program
{
    private static void Main(string[] args)
    {
        PriorityQueue<string, int> tasks = new PriorityQueue<string, int>(Comparer<int>.Create((a, b) => b - a));

        string commandLine;
        while ((commandLine = Console.ReadLine()) != null)
        {
            if (commandLine != "getNextTask")
            {
                string[] commandArgs = commandLine.Split(" ");
                string task = commandArgs[1];
                int priority = int.Parse(commandArgs[2]);
                tasks.Enqueue(task, priority);
            }
            else
            {
                GetNextTask(tasks);
            }            
        }
    }

    private static void GetNextTask(PriorityQueue<string, int> tasks)
    {
        tasks.TryDequeue(out string taskName, out int priority);
        Console.WriteLine($"{taskName} - {priority}");
    }
}