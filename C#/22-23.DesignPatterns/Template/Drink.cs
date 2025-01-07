
public abstract class Drink
{
    public void Prepare()
    {
        BoilWater();
        Brew();
        PourInCup();
        if (CustomerWantsCondiments())
        {
            AddCondiments();
        }
    }

    private void BoilWater()
    {
        Console.WriteLine("Boiling water...");
    }
    private void PourInCup()
    {
        Console.WriteLine("Pouring into a cup...");
    }
    protected abstract void Brew();
    protected abstract void AddCondiments();
    protected virtual bool CustomerWantsCondiments() => true;
}