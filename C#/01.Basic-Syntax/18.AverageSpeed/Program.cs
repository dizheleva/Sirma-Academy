double distance = double.Parse(Console.ReadLine());
int hours = int.Parse(Console.ReadLine());

double averageSpeed = distance / hours;

Console.WriteLine(averageSpeed.ToString("F2"));