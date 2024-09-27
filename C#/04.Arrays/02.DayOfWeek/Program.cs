internal class Program
{
    private static void Main(string[] args)
    {
        string[] daysOfWeek = {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"
        };

        int number = int.Parse(Console.ReadLine());

        if (number - 1 >= 0 && number - 1 < daysOfWeek.Length)
        {
            Console.WriteLine(daysOfWeek[number - 1]);
        }
        else
        {
            Console.WriteLine("Invalid Day!");
        }
    }
}