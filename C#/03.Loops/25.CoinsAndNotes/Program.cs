internal class Program
{
    private static void Main(string[] args)
    {
        int coinsOne = int.Parse(Console.ReadLine());
        int coinsTwo = int.Parse(Console.ReadLine());
        int notesFive = int.Parse(Console.ReadLine());
        int sum = int.Parse(Console.ReadLine());

        for (int cOne = 0; cOne <= coinsOne; cOne++)
        {
            for (int cTwo = 0; cTwo <= coinsTwo; cTwo++)
            {
                for (int nFive = 0; nFive <= notesFive; nFive++)
                {
                    if (cOne + cTwo * 2 + nFive * 5 == sum)
                    {
                        string output = $"{cOne} * 1 lv. + {cTwo} * 2 lv. + {nFive} * 5 lv. = {sum} lv.";
                        Console.WriteLine(output);
                    }
                }
            }
        }
    }
}