internal class Program
{
    private static void Main(string[] args)
    {
        int score = int.Parse(Console.ReadLine());
        int extracurriculars = int.Parse(Console.ReadLine());

        bool isAdmitted = true;

        if (score < 80 || score < 90 && extracurriculars < 2)
        {
            isAdmitted = false;
        }

        Console.WriteLine(isAdmitted ? "Admitted" : "Not admitted");
    }
}