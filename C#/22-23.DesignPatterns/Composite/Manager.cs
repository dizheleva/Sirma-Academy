
internal class Manager : IEmployee
{
    private List<IEmployee> subordinates = new List<IEmployee>();
    public string Name { get; set; }
    public string Position { get; set; }

    public Manager(string name, string position)
    {
        this.Name = name;
        this.Position = position;
    }

    public void AddSubordinate(IEmployee employee) => subordinates.Add(employee);

    public void RemoveSubordinate(IEmployee employee) => subordinates.Remove(employee);

    public void ShowDetails()
    {
        Console.WriteLine($"Manager: {Name}, Position: {Position}");
        Console.WriteLine("Subordinates:");
        foreach (var subordinate in subordinates)
        {
            subordinate.ShowDetails();
        }
    }
}