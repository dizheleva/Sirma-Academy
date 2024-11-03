
internal class Program
{
    private static void Main(string[] args)
    {
        double number = double.Parse(Console.ReadLine());
        int power = int.Parse(Console.ReadLine());
        double result = GetNumberPower(number, power);
        Console.WriteLine(result);
    }

    private static double GetNumberPower(double number, int power)
    {
        double result = number;

        for (int i = 0; i < power - 1; i++)
        {
            result *= number;
        }

        return result;
    }
}