namespace _05.DependencyInversionPrinciple.Bulb
{
    public class Switch
    {
        private ISwitchable Device { get; set; }

        public Switch(ISwitchable device) 
        {
            this.Device = device;
        }

        public void Operate()
        {
            this.Device.TurnOn();
            this.Device.TurnOff();
        }
    }
}
