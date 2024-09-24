double weight = double.Parse(Console.ReadLine());
double height = double.Parse(Console.ReadLine());

double bmi = weight / (height * height);

Console.WriteLine(bmi.ToString("F2"));