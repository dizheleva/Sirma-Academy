internal class Program
{
    private static void Main(string[] args)
    {
        string[] arr = Console.ReadLine().Split(",");
        int n = int.Parse(Console.ReadLine());

        int outputArrLength = (int)Math.Ceiling(arr.Length / (n * 1.0));
        string[] outputArr = new string[outputArrLength];
        int step = 0;
        for (int i = 0; i < outputArrLength; i ++)
        {
            outputArr[i] = arr[step];
            step += n;
        }

        Console.WriteLine(String.Join(' ', outputArr));
    }
}