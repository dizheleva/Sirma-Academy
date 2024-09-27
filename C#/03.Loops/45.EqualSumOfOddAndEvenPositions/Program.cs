internal class Program
{
    private static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        bool isMatch = false;

        for (int number = a; number < b; number++)
        {
            int evenSum = 0;
            int oddSum = 0;

            int currentNumber = number;
            while (currentNumber >= 10)
            {
                evenSum += currentNumber % 10;
                oddSum += (int)Math.Truncate(currentNumber / 10.0) % 10;
                currentNumber = (int)Math.Truncate(currentNumber / 100.0);
            }

            if (evenSum == oddSum)
            {
                Console.WriteLine(number);
                isMatch = true;
            }
        }

        if (!isMatch)
        {
            Console.WriteLine("None");
        }
    }
}