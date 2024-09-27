internal class Program
{
    private static void Main(string[] args)
    {
        int bottom = int.Parse(Console.ReadLine());
        int top = int.Parse(Console.ReadLine());
        int magicNumber = int.Parse(Console.ReadLine());

        string result = "";
        int counter = 0;
        
        for (int i = bottom; i <= top; i++)
        {
            bool isCombination = false;

            for (int j = bottom; j <= top; j++)
            {
                isCombination = i + j == magicNumber;
                counter++;
                if (isCombination)
                {
                    result = $"Combination {counter} - ({i} + {j} = {magicNumber})";
                    break;
                }
                else
                {
                    result = $"{counter} combinations - neither equals {magicNumber}";
                }
            }

            if (isCombination)
            {
                break;
            }
        }

        Console.WriteLine(result);
    }
}