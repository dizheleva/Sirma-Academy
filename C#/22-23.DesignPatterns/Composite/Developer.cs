internal class Developer : IEmployee
{
    public string Name { get; set; }
    public string Position { get; set; }

    public Developer(string name, string position)
    {
        this.Name = name;
        this.Position = position;
    }

    public void ShowDetails() => Console.WriteLine($"Developer: {Name}, Position: {Position}");
}