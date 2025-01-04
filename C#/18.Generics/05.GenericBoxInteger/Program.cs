using _05.GenericBoxInteger;

internal class Program
{
    private static void Main(string[] args)
    {
        var count = int.Parse(Console.ReadLine());

        for (var i = 0; i < count; i++)
        {
            var box = new Box<int>(int.Parse(Console.ReadLine()));
            Console.WriteLine(box.ToString());
        }
    }
}