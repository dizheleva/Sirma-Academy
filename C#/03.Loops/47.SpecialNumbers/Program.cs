internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1111; i <= 9999; i++)
        {

            bool isSpecial = true;

            int currentNumber = i;
            while (currentNumber >= 1)
            {
                int divider = currentNumber % 10;
                if (divider == 0 || n % divider != 0)
                {
                    isSpecial = false;
                    break;
                }

                currentNumber = (int)Math.Truncate(currentNumber / 10.0);
            }

            if (isSpecial)
            {
                Console.WriteLine(i);
            }
        }
    }
}