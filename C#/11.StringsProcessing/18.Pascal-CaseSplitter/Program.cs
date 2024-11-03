internal class Program
{
    private static void Main(string[] args)
    {
        string input = Console.ReadLine();

        List<string> result = [];
        string inputToLower = input.ToLower();

        int start = 0;

        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] != inputToLower[i])
            {
                string word = input.Substring(start, i - start);
                result.Add(word);
                start = i;
            }
        }

        result.Add(input.Substring(start));
        Console.WriteLine(String.Join(", ", result));
    }
}