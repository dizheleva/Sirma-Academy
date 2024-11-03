
internal class Program
{
    private static void Main(string[] args)
    {
        double numberOne = double.Parse(Console.ReadLine());
        char operation = char.Parse(Console.ReadLine());
        double numberTwo = double.Parse(Console.ReadLine());

        double result = Calculate(numberOne, operation, numberTwo);
        Console.WriteLine(result.ToString("F2"));
    }

    private static double Calculate(double numberOne, char operation, double numberTwo)
    {
        double result = 0;

        switch (operation)
        {
            case '*':
                result = numberOne * numberTwo;
                break;
            case '+':
                result = numberOne + numberTwo;
                break;
            case '-':
                result = numberOne - numberTwo;
                break;
            case '/':
                result = numberOne / numberTwo;
                break;
            default:
                Console.WriteLine("Invalid operation!");
                break;
        }

        return result;
    }
}