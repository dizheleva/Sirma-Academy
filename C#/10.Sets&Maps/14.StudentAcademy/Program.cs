internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string, List<double>> studentsGrades = [];

        int studentsCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < studentsCount; i++)
        {
            string name = Console.ReadLine();
            double grade = double.Parse(Console.ReadLine());

            if (!studentsGrades.ContainsKey(name))
            {
                studentsGrades.Add(name, []);
            }

            studentsGrades[name].Add(grade);
        }

        studentsGrades = studentsGrades
            .Where(x => x.Value.Average() >= 4.5)
            .ToDictionary(x => x.Key, x => x.Value);

        foreach (var student in studentsGrades)
        {
            Console.WriteLine($"{student.Key} -> {student.Value.Average():F2}");
        }
    }
}