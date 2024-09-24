double firstCabinet = double.Parse(Console.ReadLine());

double secondCabinet = 0.8 * firstCabinet;
double thirdCabinet = 1.15 * (firstCabinet + secondCabinet);

double officeCost  = firstCabinet + secondCabinet + thirdCabinet;

Console.WriteLine(officeCost.ToString("F3"));