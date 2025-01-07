internal class Designer : IEmployee
{
    public string Name { get; set; }
    public string Position { get; set; }

    public Designer(string name, string position)
    {
        this.Name = name;
        this.Position = position;
    }

    public void ShowDetails() => Console.WriteLine($"Designer: {Name}, Position: {Position}");
}