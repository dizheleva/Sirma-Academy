double distance = double.Parse(Console.ReadLine());
int fuel = int.Parse(Console.ReadLine());

double efficiency = distance / fuel;

// Fuel Efficiency = D / F
Console.WriteLine(efficiency.ToString("F2"));