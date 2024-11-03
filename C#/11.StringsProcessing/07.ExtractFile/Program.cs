internal class Program
{
    private static void Main(string[] args)
    {
        var input = Console.ReadLine().Split("\\");

        var file = input[input.Length - 1];

        var fileName = file.Substring(0, file.LastIndexOf("."));
        var extension = file.Substring(file.LastIndexOf(".") + 1);

        Console.WriteLine($"File name: {fileName}");
        Console.WriteLine($"File extension: {extension}");
    }
}