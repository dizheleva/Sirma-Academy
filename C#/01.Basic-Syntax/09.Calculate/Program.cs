internal class Program
{
    private static void Main(string[] args)
    {
        int numOne = int.Parse(Console.ReadLine()); 
        int numTwo = int.Parse(Console.ReadLine()); 

        int sum = numOne + numTwo;
        Console.WriteLine(sum);

        int difference = Math.Abs(numOne - numTwo);
        Console.WriteLine(difference);

        int multiplication = numOne * numTwo;
        Console.WriteLine(multiplication);

        double average = sum / 2.0;
        Console.WriteLine($"{average:F6}");
    }
}