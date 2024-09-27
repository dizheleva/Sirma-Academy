internal class Program
{
    private static void Main(string[] args)
    {
        int[] arr = Console.ReadLine().Split(",").Select(int.Parse).ToArray();

        int[] outputArr = [];

        foreach (int element in arr)
        {
            int currentArrLength = outputArr.Length;
            if (currentArrLength == 0 || element >= outputArr[outputArr.Length - 1])
            {
                currentArrLength++;
                int[] currentArr = new int[currentArrLength];

                for (int i = 0; i < currentArrLength - 1; i++)
                {
                    currentArr[i] = outputArr[i];
                }

                currentArr[currentArrLength - 1] = element;
                outputArr = currentArr;
            }
        }

        Console.WriteLine(String.Join(' ', outputArr));
    }
}