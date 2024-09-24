int units = int.Parse(Console.ReadLine());
double rate = double.Parse(Console.ReadLine());

double bill = units * rate + 10;

Console.WriteLine(bill.ToString("F2"));