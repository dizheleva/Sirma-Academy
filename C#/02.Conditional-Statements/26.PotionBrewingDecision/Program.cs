internal class Program
{
    private static void Main(string[] args)
    {
        string firstIngredient = Console.ReadLine();
        string secondIngredient = Console.ReadLine();

        string result = "";
        if (firstIngredient == "herbs")
        {
            if (secondIngredient == "water")
            {
                result = "Health potion";
            }
            else if (secondIngredient == "oil")
            {
                result = "Stealth potion";
            }
            else
            {
                result = "Minor stamina potion";
            }
        }
        else if (firstIngredient == "berries")
        {
            if (secondIngredient == "sugar")
            {
                result = "Speed potion";
            }
            else
            {
                result = "Minor energy potion";
            }
        }
        else
        {
            result = "No potion";
        }

        Console.WriteLine(result);
    }
}