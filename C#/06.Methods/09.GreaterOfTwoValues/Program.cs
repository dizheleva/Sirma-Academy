
internal class Program
{
    private static void Main(string[] args)
    {
        string type = Console.ReadLine();
        string valueOne = Console.ReadLine();
        string valueTwo = Console.ReadLine();

        switch (type)
        {
            case "int":
                Console.WriteLine(GetMax(int.Parse(valueOne), int.Parse(valueTwo)));
                break;
            case "char":
                Console.WriteLine(GetMax(char.Parse(valueOne), char.Parse(valueTwo))); 
                break;
            case "string":
                if (valueOne.CompareTo(valueTwo) >= 0)
                {
                    Console.WriteLine(valueOne);
                }
                else
                {
                    Console.WriteLine(valueTwo);
                }
                break;
            default:
                Console.WriteLine("Invalid type");
                break;
        }
    }

    private static int GetMax(int valueOne, int valueTwo) => valueOne >= valueTwo ? valueOne : valueTwo;

    private static char GetMax(char valueOne, char valueTwo) => valueOne >= valueTwo ? valueOne : valueTwo;
}