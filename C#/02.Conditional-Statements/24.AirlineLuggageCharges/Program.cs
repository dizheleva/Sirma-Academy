internal class Program
{
    private static void Main(string[] args)
    {
        int weight = int.Parse(Console.ReadLine());
        int dimensions = int.Parse(Console.ReadLine());

        int fee = 0;
        bool overweight = false;
        bool oversize = false;

        if (weight > 50)
        {
            fee += 100;
            overweight = true;
        }

        bool slightlyOver = false;
        int extraCm = dimensions - 158;
        if (extraCm > 0)
        {
            switch (extraCm)
            {
                case <= 20:
                    fee += 50;
                    slightlyOver = true;
                    break;
                case <= 50:
                    fee += 100;
                    oversize = true;
                    break;
                case > 50:
                    fee += 200;
                    oversize = true;
                    break;
            }
        }

        bool handling = overweight && oversize;
        if (handling)
        {
            fee += 50;
        }

        string result = $"${fee}";
        if (overweight)
        {
            if (slightlyOver)
            {
                result += " (Overweight + Slightly oversize)";
            }

            if (oversize)
            {
                result += " (Overweight + Oversize + Handling)";
            }
        }
        else
        {
            if (slightlyOver)
            {
                result += " (Slightly oversize)";
            }
            if (oversize)
            {
                result += " (Oversize)";
            }
        }

        Console.WriteLine(result);
    }
}