internal class Program
{
    private static void Main(string[] args)
    {
        double latitude = double.Parse(Console.ReadLine());
        char direction = char.Parse(Console.ReadLine());

        string result = "";
        latitude = Math.Abs(latitude);
        if (latitude > 66.5)
        {
            result = "Arctic Zone";
        }
        else if (latitude > 23.5 && latitude <= 66.5)
        {
            result = "Tempreture Zone";
        }
        if (latitude > 0 && latitude <= 23.5)
        {
            result = "Tropic Zone";
        }
        if (latitude == 0)
        {
            result = "Equator";
        }

        Console.WriteLine(result);
    }
}