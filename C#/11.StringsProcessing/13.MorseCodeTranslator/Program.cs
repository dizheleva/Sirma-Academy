using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        var morse = new Dictionary<string, char>()
            {
                {".-"   ,'A'},
                {"-..." ,'B'},
                {"-.-." ,'C'},
                {"-.."  ,'D'},
                {"."    ,'E'},
                {"..-." ,'F'},
                {"--."  ,'G'},
                {"...." ,'H'},
                {".."   ,'I'},
                {".---" ,'J'},
                {"-.-"  ,'K'},
                {".-.." ,'L'},
                {"--"   ,'M'},
                {"-."   ,'N'},
                {"---"  ,'O'},
                {".--." ,'P'},
                {"--.-" ,'Q'},
                {".-."  ,'R'},
                {"..."  ,'S'},
                {"-"    ,'T'},
                {"..-"  ,'U'},
                {"...-" ,'V'},
                {".--"  ,'W'},
                {"-..-" ,'X'},
                {"-.--" ,'Y'},
                {"--.." ,'Z'}
            };

        string[] input = Console.ReadLine().Split(" | ");

        StringBuilder result = new StringBuilder();

        foreach (var word in input)
        {
            string[] characters = word.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var character in characters)
            {

                result.Append(morse[character]);
            }

            result.Append(' ');
        }

        Console.WriteLine(result);
    }
}