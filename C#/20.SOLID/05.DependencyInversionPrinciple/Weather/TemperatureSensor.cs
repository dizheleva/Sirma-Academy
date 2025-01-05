namespace _05.DependencyInversionPrinciple.Weather
{
    public class TemperatureSensor : ITemperatureGetter
    {
        public double GetTemperature()
        {
            // Return temperature from sensor
            return 25.0; // dummy value
        }
    }
}
