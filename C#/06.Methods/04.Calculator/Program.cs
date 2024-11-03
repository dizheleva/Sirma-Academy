
internal class Program
{
    private static void Main(string[] args)
    {
        string command = Console.ReadLine();
        int numOne = int.Parse(Console.ReadLine());
        int numTwo = int.Parse(Console.ReadLine());

        switch (command)
        {
            case "add":
                Add(numOne, numTwo);
                break;
            case "multiply":
                Multiply(numOne, numTwo);
                break;
            case "subtract":
                Subtract(numOne, numTwo);
                break;
            case "divide":
                Divide(numOne, numTwo);
                break;  
            default:
                Console.WriteLine("Invalid command!");
                break;
        }
    }

    private static void Divide(int numOne, int numTwo) => Console.WriteLine(numOne / numTwo);
    private static void Subtract(int numOne, int numTwo) => Console.WriteLine(numOne - numTwo);
    private static void Multiply(int numOne, int numTwo) => Console.WriteLine(numOne * numTwo);
    private static void Add(int numOne, int numTwo) => Console.WriteLine(numOne + numTwo);
}