internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());

        string alphabet = "abcdefghijklmnopqrstuvwxyz";

        for (int s1 = 1; s1 <= n; s1++)
        {
            for (int s2 = 1; s2 <= n; s2++)
            {
                for (int i = 0; i < m; i++)
                {
                    char s3 = alphabet[i];
                    for (int j = 0; j < m; j++)
                    {
                        char s4 = alphabet[j];
                        for (int s5 = 1; s5 <= n; s5++)
                        {
                            if (s5 > s1 && s5 > s2)
                            {
                                Console.WriteLine($"{s1}{s2}{s3}{s4}{s5}");
                            }
                        }
                    }
                }
            }
        }
    }
}