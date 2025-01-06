namespace _04.InterfaceSegregationPrinciple
{
    public class SmartLight : ISwitchDevice
    {
        public void TurnOn()
        {
            Console.WriteLine("Smart Light turned on.");
        }
        public void TurnOff()
        {
            Console.WriteLine("Smart Light turned off.");
        }
    }
}
