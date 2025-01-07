using Builder;

internal class Program
{
    private static void Main(string[] args)
    {
        IComputerBuilder gamingBuilder = new Builder.Builder();
        Director director = new Director(gamingBuilder);

        Console.WriteLine("Building a gaming computer...");
        director.BuildGamingComputer();
        Computer gamingComputer = gamingBuilder.GetComputer();
        gamingComputer.ShowInfo();

        Console.WriteLine();

        Console.WriteLine("Building an office computer...");
        director.BuildOfficeComputer();
        Computer officeComputer = gamingBuilder.GetComputer();
        officeComputer.ShowInfo();
    }
}