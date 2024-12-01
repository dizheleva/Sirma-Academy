using ShapeAreaCalculator.Models;
using Rectangle = ShapeAreaCalculator.Models.Rectangle;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>
        {
            new Circle(5),
            new Rectangle(4, 6),
            new Triangle(5, 8, 4),
            new Circle(6.7),
            new Rectangle(2, 6),
            new Triangle(6, 4, 4),
            new Circle(7),
            new Rectangle(5, 10),
            new Triangle(7, 8, 3),
            new Circle(7.8),
            new Rectangle(4, 5),
            new Triangle(1, 2, 3),
            new Trapezoid(2, 4, 3, 6),
            new Trapezoid(10, 11, 4, 8),
            new Trapezoid(11, 7.5, 4, 9),
            new RegularPolygon(5, 4.7),
            new RegularPolygon(6, 6),
            new RegularPolygon(7, 5),
        };

        foreach (Shape shape in shapes)
        {
            //Console.WriteLine($"The area of the {shape.GetType().Name} is {shape.GetArea():F2}");
            Console.WriteLine(shape.ToString());
            Console.WriteLine();
        }
    }
}