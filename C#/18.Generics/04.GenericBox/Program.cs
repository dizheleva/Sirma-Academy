using _04.GenericBox;

internal class Program
{
    private static void Main(string[] args)
    {
        var count = int.Parse(Console.ReadLine());

        for (var i = 0; i < count; i++)
        {
            var input = Console.ReadLine();

            if (Int32.TryParse(input, out _))
            {
                var box = new Box<int>(int.Parse(input));
                Console.WriteLine(box.ToString());
            }
            else if (double.TryParse(input, out _))
            {
                var box = new Box<double>(double.Parse(input));
                Console.WriteLine(box.ToString());
            }
            else if (bool.TryParse(input, out _))
            {
                var box = new Box<bool>(bool.Parse(input));
                Console.WriteLine(box.ToString());
            }
            else if (char.TryParse(input, out _))
            {
                var box = new Box<char>(char.Parse(input));
                Console.WriteLine(box.ToString());
            }
            else
            {
                var box = new Box<string>(input);
                Console.WriteLine(box.ToString());
            }
        }
    }
}
