namespace _02.OpenClosedPriciple.Logger
{
    public class FileLogger : Logger
    {
        public string filePath = $@"C:\\Logs\\Log-{DateTime.Today:MM-dd-yyyy}.txt";
        public override void Log(string message)
        {
            using var streamWriter = new StreamWriter(filePath);
            streamWriter.WriteLine("Log Entry : ");
            streamWriter.WriteLine($"{DateTime.Now.ToLongTimeString()} {DateTime.Now.ToLongDateString()}");
            streamWriter.WriteLine("**********");
            streamWriter.WriteLine(message);
            streamWriter.WriteLine("-------------------------------");
            streamWriter.Close();
        }
    }
}
