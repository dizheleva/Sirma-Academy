internal class Program
{
    private static void Main(string[] args)
    {
        double[] nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

        Dictionary<double, int> map = nums.Distinct().ToDictionary(x => x, x => nums.Count(y => y == x));

        //foreach (double num in nums)
        //{
        //    if (map.ContainsKey(num))
        //    {
        //        map[num]++;
        //    }
        //    else
        //    {
        //        map.Add(num, 1);
        //    }
        //}

        foreach (var item in map)
        {
            Console.WriteLine($"{item.Key:F1} -> {item.Value}");
        }
    }
}