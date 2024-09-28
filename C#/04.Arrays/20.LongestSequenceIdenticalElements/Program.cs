internal class Program
{
    private static void Main(string[] args)
    {
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int maxLength = 0;
        int repeatNumber = 0;
        int counter = 0;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] == arr[i + 1])
            {
                counter++;
                if (counter > maxLength)
                {
                    maxLength = counter;
                    repeatNumber = arr[i];
                }
            }
            else
            {
                counter = 0;
            }
        }

        int[] newArr = new int[maxLength + 1];
        for (int j = 0; j < newArr.Length; j++)
        {
            newArr[j] = repeatNumber;
        }

        Console.WriteLine(String.Join(' ', newArr));
    }
}