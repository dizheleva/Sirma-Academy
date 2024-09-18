internal class Program
{
    private static void Main(string[] args)
    {
        double kilometers = double.Parse(Console.ReadLine());
        const double relation = 0.621371192;
        double miles = kilometers * relation;

        Console.WriteLine(miles);
    }
}