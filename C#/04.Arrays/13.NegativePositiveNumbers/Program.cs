internal class Program
{
    private static void Main(string[] args)
    {
        int[] arr = Console.ReadLine().Split(",").Select(int.Parse).ToArray();
        int[] outputArr = [];
      
        foreach (int element in arr)
        {          
            int[] currentArr = new int[outputArr.Length + 1];
            if (currentArr.Length == 0 || element >= 0)
            {
                for (int i = 0; i < currentArr.Length - 1; i++)
                {
                    currentArr[i] = outputArr[i];
                }
                currentArr[currentArr.Length - 1] = element;
            }
            else
            {
                currentArr[0] = element;
                for (int i = 1; i < currentArr.Length; i++)
                {
                    currentArr[i] = outputArr[i - 1];
                }
            }
            outputArr = currentArr;
        }

        foreach (int currentElement in outputArr)
        {
            Console.WriteLine(currentElement);
        }
    }
}