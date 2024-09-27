internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string reversed = "";

        while (n >= 1)
        {
            reversed += (n % 10);
            n = n / 10;
        }

        Console.WriteLine(reversed);
    }
}