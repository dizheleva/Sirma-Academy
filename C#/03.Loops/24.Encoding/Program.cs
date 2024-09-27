internal class Program
{
    private static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        while (number > 0)
        {
            int digit = number % 10;
            int charCode = digit + 33;

            string line = "";
            if (digit == 0)
            {
                line = "ZERO";
            }
            else
            {
                for (int i = 0; i < digit; i++)
                {
                    line += (char)charCode;
                }
            }

            Console.WriteLine(line);
            number /= 10;
        }
    }
}