internal class Program
{
    private static void Main(string[] args)
    {
        string figure = Console.ReadLine();
        double area = 0;

        switch (figure)
        {
            case "square":
                double side = double.Parse(Console.ReadLine());
                area = side * side;
                break;
            case "rectangle":
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                area = a * b;
                break;
            case "circle":
                double radius = double.Parse(Console.ReadLine());
                area = radius * radius * Math.PI;
                break;
            case "triangle":
                double triangleSide = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                area = triangleSide * height / 2;
                break;
            default:
                Console.WriteLine("Ivalid Input!");
                break;
        }

        Console.WriteLine(area.ToString("F2"));
    }
}