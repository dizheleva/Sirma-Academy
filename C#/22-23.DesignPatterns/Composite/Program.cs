internal class Program
{
    private static void Main(string[] args)
    {
        IEmployee dev1 = new Developer("Alice", "Frontend Developer");
        IEmployee dev2 = new Developer("Bob", "Backend Developer");
        IEmployee designer = new Designer("Eve", "UI/UX Designer");

        Manager teamLead = new Manager("Charlie", "Team Lead");
        teamLead.AddSubordinate(dev1);
        teamLead.AddSubordinate(dev2);
        teamLead.AddSubordinate(designer);

        Manager projectManager = new Manager("Diana", "Project Manager");
        projectManager.AddSubordinate(teamLead);

        Console.WriteLine("Organization Structure:");
        projectManager.ShowDetails();
    }
}