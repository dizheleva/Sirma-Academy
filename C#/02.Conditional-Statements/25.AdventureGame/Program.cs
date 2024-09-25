internal class Program
{
    private static void Main(string[] args)
    {
        string rightHand = Console.ReadLine();
        string leftHand = Console.ReadLine();

        string result = "";
        if (rightHand == "sword")
        {
            if (leftHand == "shield")
            {
                result = "Path to the castle";
            }
            else
            {
                result = "Path to the forest";
            }
        }
        else if (rightHand == "map")
        {
            if (leftHand == "coins")
            {
                result = "Go to the town";
            }
            else
            {
                result = "Camp";
            }
        }
        else
        {
            result = "Wander aimlessly";
        }

        Console.WriteLine(result);
    }
}