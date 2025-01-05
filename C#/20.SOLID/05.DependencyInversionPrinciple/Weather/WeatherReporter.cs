namespace _05.DependencyInversionPrinciple.Weather
{
    public class WeatherReporter
    {
        private ITemperatureGetter Sensor { get; set; }

        public WeatherReporter(ITemperatureGetter sensor)
        {
            this.Sensor = sensor;
        }

        public string Report()
        {
            return "Current temperature: " + this.Sensor.GetTemperature();
        }
    }
}
