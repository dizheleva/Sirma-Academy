internal class Program
{
    private static void Main(string[] args)
    {
        string time = Console.ReadLine();
        string environment = Console.ReadLine();
        string item = Console.ReadLine();

        string result = "";
        if (time == "day")
        {
            if (environment == "forest")
            {
                if (item == "knife")
                {
                    result = "Hunt for food";
                }
                else if (item == "container")
                {
                    result = "Collect berries";
                }
                else
                {
                    result = "Explore";
                }
            }
            else if (environment == "desert")
            {
                if (item == "hat")
                {
                    result = "Search for water";
                }
                else
                {
                    result = "Find shade";
                }
            }
        }
        else if (time == "night")
        {
            if (environment == "forest")
            {
                if (item == "firestarter")
                {
                    result = "Make a campfire";
                }
                else
                {
                    result = "Climb a tree";
                }
            }
            else if (environment == "desert")
            {
                if (item == "blanket")
                {
                    result = "Sleep";
                }
                else
                {
                    result = "Keep moving to stay warm";
                }
            }
        }

        Console.WriteLine(result);
    }
}