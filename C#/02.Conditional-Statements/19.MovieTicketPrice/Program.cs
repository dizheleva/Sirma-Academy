internal class Program
{
    private static void Main(string[] args)
    {
        int age = int.Parse(Console.ReadLine());

        if (age > 0 && age <= 12)
        {
            Console.WriteLine("$5");
        }
        else if (age <= 19)
        {
            Console.WriteLine("$8");
        }
        else 
        {
            Console.WriteLine("$10");
        }
    }
}