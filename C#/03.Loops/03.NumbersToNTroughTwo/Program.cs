﻿internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i += 2)
        {
            Console.WriteLine(i);
        }
    }
}