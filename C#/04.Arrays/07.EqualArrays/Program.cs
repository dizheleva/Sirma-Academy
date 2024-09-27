internal class Program
{
    private static void Main(string[] args)
    {
        string[] firstArr = Console.ReadLine().Split(",");
        string[] secondArr = Console.ReadLine().Split(",");

        int sum = 0;
        bool isIdentical = true;
        int index;

        for (index = 0; index < firstArr.Length; index++)
        {
            if (firstArr[index] == secondArr[index])
            {
                sum += int.Parse(firstArr[index]);
            }
            else
            {
                isIdentical = false;
                break;
            }
        }

        string output = isIdentical 
            ? $"Arrays are identical. Sum: {sum}"
            : $"Arrays are not identical. Found difference at {index} index";

        Console.WriteLine(output);
    }
}