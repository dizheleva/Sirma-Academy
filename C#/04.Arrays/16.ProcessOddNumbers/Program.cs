using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] arr = Console.ReadLine().Split(",").Select(int.Parse).ToArray();

        int[] outputArr = [];
        int startIndex = arr.Length % 2 == 0 ? arr.Length - 1 : arr.Length - 2;
        for (int i = startIndex; i >= 0; i -= 2)
        {            
            int[] tempArr = new int[outputArr.Length + 1];
            for (int j = 0; j < tempArr.Length - 1; j++)
            {
                tempArr[j] = outputArr[j];
            }

            int number = arr[i] * 2;
            tempArr[tempArr.Length - 1] = number;

            outputArr = tempArr;
        }

        Console.WriteLine(String.Join(' ', outputArr));
    }
}