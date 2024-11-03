using _06.RandomizeWords;

internal class Program
{
    private static void Main(string[] args)
    {
        List<string> inputList = [.. Console.ReadLine().Split(" ")];
        Randomizer randomizer = new Randomizer();
        List<string> outputList = randomizer.Randomize(inputList);
        outputList.ForEach(item => Console.WriteLine(item));
    }
}