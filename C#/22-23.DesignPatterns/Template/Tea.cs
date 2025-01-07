public class Tea : Drink
{
    protected override void AddCondiments() => Console.WriteLine("Adding lemon...");
    protected override void Brew() => Console.WriteLine("Steeping the tea...");

}