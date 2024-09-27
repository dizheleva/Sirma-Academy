internal class Program
{
    private static void Main(string[] args)
    {
        string[] commands = Console.ReadLine().Split(",");

        int inputNumber = 0;
        int[] outputArr = [];

        foreach (string command in commands)
        {
            int currentArrLength = outputArr.Length;
            if (command == "add")
            {
                currentArrLength++;
                inputNumber++;
            }
            else if (command == "remove" && currentArrLength > 0)
            {
                currentArrLength--;
            }

            int[] currentArr = new int[currentArrLength];

            for (int i = 0; i < currentArrLength; i++)
            {
                if (currentArrLength > outputArr.Length && i == currentArrLength - 1)
                {
                    currentArr[currentArrLength - 1] = inputNumber;
                }
                else
                {
                    currentArr[i] = outputArr[i];
                }
            }

            outputArr = currentArr;
        }

        string output = outputArr.Length != 0 ? String.Join(' ', outputArr) : "Empty";
        Console.WriteLine(output);
    }
}