internal class Program
{
    private static void Main(string[] args)
    {
        int firstLimit = int.Parse(Console.ReadLine());
        int secondLimit = int.Parse(Console.ReadLine());
        int thirdLimit = int.Parse(Console.ReadLine());

        for (int firstDigit = 1; firstDigit <= firstLimit; firstDigit++)
        {
            if (firstDigit % 2 == 0)
            {
                if (secondLimit >= 2 && secondLimit <= 7)
                {
                    for (int secondDigit = 2; secondDigit <= secondLimit; secondDigit++)
                    {
                        bool isPrime = true;
                        for (int i = 2; i < secondDigit; i++)
                        {
                            if (secondDigit % i == 0)
                            {
                                isPrime = false;
                            }

                        }

                        if (isPrime)
                        {
                            for (int thirdDigit = 1; thirdDigit <= thirdLimit; thirdDigit++)
                            {
                                if (thirdDigit % 2 == 0)
                                {
                                    Console.WriteLine($"{firstDigit}{secondDigit}{thirdDigit}");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
