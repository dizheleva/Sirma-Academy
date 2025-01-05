namespace _05.DependencyInversionPrinciple.Bulb
{
    public class Bulb : ISwitchable
    {
        public void TurnOn() => Console.WriteLine("Turned On!");
        public void TurnOff() => Console.WriteLine("Turned Off!");
    }
}
