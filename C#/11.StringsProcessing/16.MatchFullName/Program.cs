using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        var regex = new Regex(@"\b[A-Z][a-z]+ [A-Z][a-z]+\b");

        var names = Console.ReadLine();

        var matchedNames = regex.Matches(names);

        foreach (var name in matchedNames)
        {
            Console.Write(name + " ");
        }
    }
}