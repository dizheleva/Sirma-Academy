
internal class Program
{
    private static void Main(string[] args)
    {
        PriorityQueue<Robot, int> robots = new();

        string[] robotsArr = Console.ReadLine().Split("|");

        for (int i = 1; i <= robotsArr.Length; i++)
        {
            string[] robotArgs = robotsArr[i - 1].Split("-");
            string name = robotArgs[0];
            int time = int.Parse(robotArgs[1]);
            robots.Enqueue(new Robot(name, time), i);
        }

        int[] startingTime = Console.ReadLine().Split(":").Select(int.Parse).ToArray();
        
        Queue<string> products = new Queue<string>();

        string product;
        while ((product = Console.ReadLine()) != "End")
        {
            products.Enqueue(product);
        }

        int secondsElapsed = 0;

        while (products.Count > 0)
        {
            robots.TryDequeue(out Robot robot, out int currentPriority);
            secondsElapsed = currentPriority;
            Console.WriteLine($"{robot.Name} - {products.Dequeue()} [{GetTimeFormat(startingTime, secondsElapsed)}]");
            robots.Enqueue(robot, robot.Time + secondsElapsed);

            robots.TryPeek(out Robot nextRobot, out int nextPriority);

            if (nextPriority == currentPriority)
            {
                nextPriority++;
                robots.EnqueueDequeue(nextRobot, nextPriority);
            }

            int secondsWithoutRobot = nextPriority - secondsElapsed - 1;

            for (int i = 0; i < secondsWithoutRobot && products.Count > 0; i++)
            {
                products.Enqueue(products.Dequeue());
            }
        }
    }

    private static string GetTimeFormat(int[] startingTime, int secondsElapsed)
    {
        int seconds = startingTime[2] + secondsElapsed % 60;
        int minutes = (startingTime[1] + secondsElapsed / 60) % 60;
        int hours = startingTime[0] + minutes / 60;

        return $"{hours:D2}:{minutes:D2}:{seconds:D2}";
    }

    private class Robot(string name, int time)
    {
        public string Name { get; set; } = name;
        public int Time { get; set; } = time;
    }
}