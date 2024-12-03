namespace ShapeAreaCalculator
{
    using System.Text.Json;
    using ShapeAreaCalculator.Models;

    public class ShapesContext
    {
        public static List<Shape> Shapes { get; set; } = [];              

        public static void SaveChanges() => DataSerializer.SaveData(Shapes);

        public static void LoadData() => Shapes = DataSerializer.LoadData();
    }
}
