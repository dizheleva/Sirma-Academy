using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int sum = 0;
        int a = 0;
        int b = 1;

        for (int i = 0; i <= n; i++)
        {
            sum += a;
            int step = a + b;
            a = b;
            b = step;
        }

        Console.WriteLine(sum);
    }
}