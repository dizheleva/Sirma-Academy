int n = int.Parse(Console.ReadLine());

double red = n / 13.0;
double yellow = 4 * red;
double white = 2 * yellow;

Console.WriteLine($"Red: {red:F4}");
Console.WriteLine($"Yellow: {yellow:F4}");
Console.WriteLine($"White: {white:F4}");