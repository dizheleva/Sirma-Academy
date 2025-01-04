using _03.GenericScale;

internal class Program
{
    private static void Main(string[] args)
    {
        var scale = new Scale<string>("10", "3");

        Console.WriteLine(scale.GetHeavier());
    }
}