using _04.InterfaceSegregationPrinciple;

internal class Program
{
    private static void Main(string[] args)
    {
        SmartLight lamp = new SmartLight();
        lamp.TurnOn();
        lamp.TurnOff();

        SmartThermostat thermostat = new SmartThermostat();
        thermostat.TurnOn();
        thermostat.TurnOff();
        thermostat.SetTemperature(22);
    }
}