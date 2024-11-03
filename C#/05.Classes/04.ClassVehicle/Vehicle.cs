namespace _04.ClassVehicle
{
    public class Vehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public int Fuel { get; set; }

        public Vehicle(string type, string model, Engine engine, int fuel)
        {
            this.Type = type;
            this.Model = model;
            this.Engine = engine;
            this.Fuel = fuel;
        }

        public void Drive(int fuelLoss)
        {
            this.Fuel -= fuelLoss;
        }
    }
}
