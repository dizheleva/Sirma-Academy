using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int currentNum = 1;
        int line = 1;
        while (true)
        {
            string output = "";

            bool isOver = false;
            for (int i = 1; i <= line; i++)
            {
                output += $"{currentNum} ";
                if (currentNum == n)
                {
                    isOver = true;
                    break;
                }
                currentNum++;
            }

            Console.WriteLine(output.Trim());

            line++;
            if (isOver)
            {
                break;
            }
        }
    }
}