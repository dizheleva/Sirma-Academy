internal class Program
{
    private static void Main(string[] args)
    {
        int firstPairInput = int.Parse(Console.ReadLine());
        int secondPairInput = int.Parse(Console.ReadLine());
        int differenceFirstPair = int.Parse(Console.ReadLine());
        int differenceSecondPair = int.Parse(Console.ReadLine());

        for (int firstPair = firstPairInput; firstPair <= firstPairInput + differenceFirstPair; firstPair++)
        {
            bool isFirstPrime = true;
            for (int i = 2; i < firstPair; i++)
            {
                if (firstPair % i == 0)
                {
                    isFirstPrime = false;
                }
            }

            if (isFirstPrime)
            {
                for (int secondPair = secondPairInput; secondPair <= secondPairInput + differenceSecondPair; secondPair++)
                {
                    bool isSecondPrime = true;
                    for (int i = 2; i < secondPair; i++)
                    {
                        if (secondPair % i == 0)
                        {
                            isSecondPrime = false;
                        }
                    }

                    if (isSecondPrime)
                    {
                        Console.WriteLine($"{firstPair}{secondPair}");
                    }
                }
            }
        }
    }
}