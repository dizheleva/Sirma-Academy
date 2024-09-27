using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        string textNumber = n.ToString();
        int digitsCount = textNumber.Length;
        double result = 0;

        for (int i = 0; i < digitsCount; i++)
        {
            int digit = int.Parse(textNumber[i].ToString());
            result += Math.Pow(digit, digitsCount);
        }

        bool isArmstrong = result == n;

        // Console.WriteLine(isArmstrong.ToString().ToLower());
        Console.WriteLine(isArmstrong ? "Armstrong" : "Not Armstrong");
    }
}