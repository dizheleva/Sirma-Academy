
internal class Program
{
    private static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        int result = GetEvenSum(number) * GetOddSum(number);
        Console.WriteLine(result);
    }

    private static int GetOddSum(int number)
    {
        int oddSum = 0;

        while (number > 0)
        {
            int lastDigit = number % 10;

            if (lastDigit % 2 != 0)
            {
                oddSum += lastDigit;
            }

            number = number / 10;
        }

        return oddSum;
    }
    private static int GetEvenSum(int number)
    {
        int evenSum = 0;

        while (number > 0)
        {
            int lastDigit = number % 10;

            if (lastDigit % 2 == 0)
            {
                evenSum += lastDigit;
            }

            number = number / 10;
        }

        return evenSum;
    }
}