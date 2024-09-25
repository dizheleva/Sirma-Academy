internal class Program
{
    private static void Main(string[] args)
    {
        int year = int.Parse(Console.ReadLine());

        bool isLeap = true;

        if (year % 4 == 0 && (year % 100 != 0 || (year % 100 == 0 && year % 400 == 0)))
        {
            isLeap = true;
        }
        else
        {
            isLeap = false;
        }

        string result = isLeap ? "It`s a leap year!" : "It`s not a leap year.";
        Console.WriteLine(result);
    }
}