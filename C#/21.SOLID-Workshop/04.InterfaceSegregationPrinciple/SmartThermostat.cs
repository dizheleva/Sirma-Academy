namespace _04.InterfaceSegregationPrinciple
{
    public class SmartThermostat : ISwitchDevice, ITemperatureControlDevice
    {
        public void TurnOn()
        {
            Console.WriteLine("Smart Thermostat turned on.");
        }
        public void TurnOff()
        {
            Console.WriteLine("Smart Thermostat turned off.");
        }
        public void SetTemperature(int temperature)
        {
            Console.WriteLine($"Temperature set to {temperature}°C.");
        }
    }
}
