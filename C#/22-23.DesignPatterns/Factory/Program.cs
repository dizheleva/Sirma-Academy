internal class Program
{
    private static void Main(string[] args)
    {
        var shapeFactory = new Factory.ShapeFactory();
        var circle = shapeFactory.GetShape("circle");
        circle.Draw();
        var rectangle = shapeFactory.GetShape("rectangle");
        rectangle.Draw();
        var square = shapeFactory.GetShape("square");
        square.Draw();
    }
}