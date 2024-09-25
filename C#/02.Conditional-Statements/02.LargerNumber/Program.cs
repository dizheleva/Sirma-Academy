internal class Program
{
    private static void Main(string[] args)
    {
        int numberOne = int.Parse(Console.ReadLine());
        int numberTwo = int.Parse(Console.ReadLine());

        if (numberOne > numberTwo)
        {
            Console.WriteLine(numberOne);
        }
        else
        {
            Console.WriteLine(numberTwo);
        }
    }
}