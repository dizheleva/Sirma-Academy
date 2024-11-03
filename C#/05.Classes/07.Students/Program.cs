using _07.Students;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Student> students = new List<Student>();

        string inputLine;
        while ((inputLine = Console.ReadLine()) != "end")
        {
            string[] studentArgs = inputLine.Split(" ").ToArray();
            Student student = new Student(studentArgs[0], studentArgs[1], int.Parse(studentArgs[2]), studentArgs[3]);
            students.Add(student);
        }
        
        string town = Console.ReadLine();
        students.Where(student => student.Hometown == town).ToList().ForEach(student => Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old"));
    }
}