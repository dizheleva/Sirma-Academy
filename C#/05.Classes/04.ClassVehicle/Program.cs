using _04.ClassVehicle;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter engine power..");
        int power = int.Parse(Console.ReadLine());
        Engine engine = new Engine(power);

        Console.WriteLine("Enter vehicle type..");
        string type = Console.ReadLine();
        Console.WriteLine("Enter vehicle model..");
        string model = Console.ReadLine();
        Console.WriteLine("Enter vehicle current fuel..");
        int fuel = int.Parse(Console.ReadLine());
        Vehicle vehicle = new Vehicle(type, model, engine, fuel);
        
        Console.WriteLine("Enter driving fuel loss..");
        int fuelLoss = int.Parse(Console.ReadLine());
        vehicle.Drive(fuelLoss);
        Console.WriteLine($"Vehicle {vehicle.Type} {vehicle.Model} has {vehicle.Fuel} fuel left.");
    }
}