namespace ShapeAreaCalculator
{
    using ShapeAreaCalculator.DataSerialization;
    using ShapeAreaCalculator.Models;

    public class ShapesRepository
    {
        public static List<Shape> Shapes { get; } = DataSerializer.LoadData();

        public static int Count => Shapes.Count;        

        public static void Add(Shape shape)
        {
            if (shape == null)
            {
                throw new ArgumentException("Shape cannot be null");
            }

            Shapes.Add(shape);
            DataSerializer.SaveData((List<Shape>)Shapes);
        }

        public static bool Remove(Shape shape)
        {
            if (shape == null)
            {
                throw new ArgumentException("Shape cannot be null");
            }

            var result = Shapes.Remove(shape);
            if (result)
            {
                DataSerializer.SaveData(Shapes);
            }
            return result;
        }

        public static Shape Find(int index)
        {
            if (index < 0 || index >= Shapes.Count)
            {
                throw new ArgumentOutOfRangeException("Invalid shape number!");
            }

            return Shapes[index];
        }

        public static void SaveChanges() => DataSerializer.SaveData(Shapes);
        
        //public void LoadData() => Shapes = DataSerializer.LoadData();
    }
}