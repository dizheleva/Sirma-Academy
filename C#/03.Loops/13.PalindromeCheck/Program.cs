internal class Program
{
    private static void Main(string[] args)
    {
        string word = Console.ReadLine();
        string mirrorWord = "";

        for (int i = word.Length - 1; i >= 0; i--)
        {
            mirrorWord += word[i];
        }

        bool isPalindrome = word == mirrorWord;
        Console.WriteLine(isPalindrome.ToString().ToLower());
    }
}