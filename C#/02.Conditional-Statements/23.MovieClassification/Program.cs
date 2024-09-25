internal class Program
{
    private static void Main(string[] args)
    {
        int age = int.Parse(Console.ReadLine());

        int discount = 0;
        switch (age)
        {
            case < 13:
                Console.WriteLine("U-rated movies");
                break;
            case <= 17:
                Console.WriteLine("U and PG-13 rated movies");
                break;
            case >= 18:
                Console.WriteLine("All movies");
                break;
        }
    }
}