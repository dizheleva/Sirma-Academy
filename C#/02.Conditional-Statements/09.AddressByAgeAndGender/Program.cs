internal class Program
{
    private static void Main(string[] args)
    {
        int age = int.Parse(Console.ReadLine());
        char gender = char.Parse(Console.ReadLine());

        switch (gender)
        {
            case 'f':
                switch (age)
                {
                    case < 16:
                        Console.WriteLine("Miss");
                        break;
                    default:
                        Console.WriteLine("Ms.");
                        break;
                }
                break;
            case 'm':
                switch (age)
                {
                    case < 16:
                        Console.WriteLine("Master");
                        break;
                    default:
                        Console.WriteLine("Mr.");
                        break;
                }
                break;
        }
    }
}