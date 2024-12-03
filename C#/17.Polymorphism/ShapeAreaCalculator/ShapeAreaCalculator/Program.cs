using System.Globalization;
using System.Text.Json;
using ShapeAreaCalculator;
using ShapeAreaCalculator.Models;
using Rectangle = ShapeAreaCalculator.Models.Rectangle;

internal class Program
{
    private static void Main(string[] args)
    {        
        //List<Shape> shapes = new List<Shape>()
        //{
        //    new Circle(5),
        //    new Rectangle(4, 6),
        //    new Triangle(5, 8, 4),
        //    new Circle(6.7),
        //    new Rectangle(2, 6),
        //    new Triangle(6, 4, 4),
        //    new Circle(7),
        //    new Rectangle(5, 10),
        //    new Triangle(7, 8, 3),
        //    new Circle(7.8),
        //    new Rectangle(4, 5),
        //    new Trapezoid(13, 8, 12, 8),
        //    new Trapezoid(12, 9, 6, 8),
        //    new Trapezoid(11, 7.5, 7, 6),
        //    new Trapezoid(7, 5, 9, 10),
        //    new Trapezoid(17, 8, 13, 8),
        //    new RegularPolygon(5, 4.7),
        //    new RegularPolygon(6, 6),
        //    new RegularPolygon(7, 5),
        //};

        //FileIO.SaveData(shapes);

        ShapesContext.LoadData();
        ConsoleMenu.Run();
    }
}