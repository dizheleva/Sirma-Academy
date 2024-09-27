internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        int[] arr = [];
        for (int i = 0; i < n; i++)
        {
            int nextElement = 0;
            int stopSumming = arr.Length > k ? k : arr.Length;

            for (int l = 0; l < stopSumming; l++)
            {
                nextElement += arr[arr.Length - l - 1];
            }

            int[] currentArr = new int[arr.Length + 1];
            for (int m = 0; m < currentArr.Length - 1; m++)
            {
                currentArr[m] = arr[m];
            }

            currentArr[currentArr.Length - 1] = nextElement != 0 ? nextElement : 1;
            arr = currentArr;
        }

        Console.WriteLine(String.Join(' ', arr));
    }
}