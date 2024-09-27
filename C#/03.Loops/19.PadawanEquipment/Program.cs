internal class Program
{
    private static void Main(string[] args)
    {
        double money = double.Parse(Console.ReadLine());
        int students = int.Parse(Console.ReadLine());
        double saberPrice = double.Parse(Console.ReadLine());
        double robePrice = double.Parse(Console.ReadLine());
        double beltPrice = double.Parse(Console.ReadLine());

        double sabersCost = Math.Ceiling(1.1 * students) * saberPrice;
        double robesCost = students * robePrice;
        double beltsCost = (students - students / 6) * beltPrice;
        double totalCost = sabersCost + robesCost + beltsCost;

        string result;
        if (money >= totalCost)
        {
            result = $"The money is enough - it would cost {totalCost:F2}lv.";
        }
        else
        {
            result = $"George Lucas will need {(totalCost - money):F2}lv more.";
        }

        Console.WriteLine(result);
    }
}