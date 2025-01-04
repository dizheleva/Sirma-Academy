using System.ComponentModel;
using _02.GenericArrayCreator;

internal class Program
{
    private static void Main(string[] args)
    {
        var strings = ArrayCreator.Create(5, "Pesho");

        Console.WriteLine(String.Join(", ", strings));
    }
}
