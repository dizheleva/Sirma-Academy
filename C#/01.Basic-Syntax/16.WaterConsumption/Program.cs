int totalWeeklyConsumption = int.Parse(Console.ReadLine());
int people = int.Parse(Console.ReadLine()); 

double dailyConsumptionPerPerson = totalWeeklyConsumption / (7 * 1.00) / (people * 1.00);

Console.WriteLine(dailyConsumptionPerPerson.ToString("F2"));