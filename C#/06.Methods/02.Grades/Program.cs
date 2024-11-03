internal class Program
{
    private static void Main(string[] args)
    {
        double grade = double.Parse(Console.ReadLine());
        Console.WriteLine(GetGradeName(grade));
    }

    private static string GetGradeName(double grade)
    {
        string gradeName;

        if (grade >= 2.00 && grade <= 2.99)
        {
            gradeName = "Fail";
        }
        else if (grade > 2.99 && grade <= 3.49)
        {
            gradeName = "Poor";
        }
        else if (grade > 3.49 && grade <= 4.49)
        {
            gradeName = "Good";
        }
        else if (grade > 4.49 && grade <= 5.49)
        {
            gradeName = "Very good";
        }
        else if (grade > 5.49 && grade <= 6.00)
        {
            gradeName = "Excellent";
        }
        else
        {
            gradeName = "Invalid grade entered!";
        }

        return gradeName;
    }
}