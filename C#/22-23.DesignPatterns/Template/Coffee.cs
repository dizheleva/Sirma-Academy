public class Coffee : Drink
{
    protected override void AddCondiments() => Console.WriteLine("Adding sugar and milk...");
    protected override void Brew() => Console.WriteLine("Brewing the coffee grounds...");

    protected override bool CustomerWantsCondiments()
    {
        Console.Write("Do you want to add sugar and milk to your coffee (y/n)? ");
        string answer = Console.ReadLine()?.ToLower();
        return answer == "y";
    }
}