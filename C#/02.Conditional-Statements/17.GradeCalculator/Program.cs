internal class Program
{
    private static void Main(string[] args)
    {
        int score = int.Parse(Console.ReadLine());

        char grade;

        if (score <= 59)
        {
            grade = 'F';
        }
        else if (score <= 69)
        {
            grade = 'D';
        }
        else if (score <= 79)
        {
            grade = 'C';
        }
        else if (score <= 89)
        {
            grade = 'B';
        }
        else
        {
            grade = 'A';
        }
        
        Console.WriteLine(grade);
    }
}