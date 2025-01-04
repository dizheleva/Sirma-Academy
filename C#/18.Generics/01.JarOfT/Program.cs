using _01.JarOfT;

internal class Program
{
    private static void Main(string[] args)
    {
        var jar = new Jar<int>();

        jar.Add(13);
        jar.Add(42);
        jar.Add(69);

        Console.WriteLine(jar.Remove());
    }
}