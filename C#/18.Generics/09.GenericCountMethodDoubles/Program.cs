﻿internal class Program
{
    private static void Main(string[] args)
    {
        var count = int.Parse(Console.ReadLine());
        var items = new List<double>();

        for (var i = 0; i < count; i++)
        {
            items.Add(double.Parse(Console.ReadLine()));
        }

        var element = double.Parse(Console.ReadLine());

        Console.WriteLine(GreaterCounter(items, element));
    }

    private static int GreaterCounter<T>(List<T> items, T element)
        where T : IComparable<T>
    {
        var count = 0;

        foreach (var item in items)
        {
            if (item.CompareTo(element) > 0)
            {
                count++;
            }
        }

        return count;
    }
}