internal class Program
{
    private static void Main(string[] args)
    {
        int year = int.Parse(Console.ReadLine());
        string material = Console.ReadLine();

        string result = "";
        if (year < 500 && material == "stone") 
        {
            result = "Ancient";
        }
        else if (year >= 500 && year <= 1500 && material == "stone")
        {
            result = "Medieval";
        }
        else if (year >= 1500 && year <= 1800 && material == "wood")
        {
            result = "Colonial";
        }
        else if (year >= 1800 && year <= 1900 && material == "steel")
        {
            result = "Industrial";
        }
        else if (year > 1900 && material == "steel")
        {
            result = "Modern";
        }
        else
        {
            result = "Uncertain";
        }

        Console.WriteLine(result);
    }
}