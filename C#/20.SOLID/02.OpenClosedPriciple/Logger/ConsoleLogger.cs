namespace _02.OpenClosedPriciple.Logger
{
    public class ConsoleLogger : Logger
    {
        public override void Log(string message)
        {
            Console.WriteLine($"{DateTime.Now.ToLongTimeString()} {DateTime.Now.ToLongDateString()}");
            Console.WriteLine("**********");
            Console.WriteLine(message);
            Console.WriteLine("-------------------------------");
        }
    }
}
