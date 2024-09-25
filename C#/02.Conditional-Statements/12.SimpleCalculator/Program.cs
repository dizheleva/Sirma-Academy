internal class Program
{
    private static void Main(string[] args)
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        string operation = Console.ReadLine();

        double result = 0;

        switch (operation)
        {
            case "add":
                result = a + b; 
                break;
            case "subtract":
                result = a - b; 
                break;
            case "multiply":
                result = a * b; 
                break;
            case "divide":
                result = a / (b * 1.0); 
                break;
        }

        Console.WriteLine(result.ToString("F2"));
    }
}