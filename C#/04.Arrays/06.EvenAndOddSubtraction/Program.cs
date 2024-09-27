﻿internal class Program
{
    private static void Main(string[] args)
    {
        int[] arr = Console.ReadLine().Split(",").Select(int.Parse).ToArray();

        int evenSum = 0;
        int oddSum = 0;

        for (int i = 0; i < arr.Length; i++)
        {

            if (arr[i] % 2 == 0)
            {
                evenSum += arr[i];
            }
            else
            {
                oddSum += arr[i];
            }
        }

        int result = evenSum - oddSum;
        Console.WriteLine(result);
    }
}