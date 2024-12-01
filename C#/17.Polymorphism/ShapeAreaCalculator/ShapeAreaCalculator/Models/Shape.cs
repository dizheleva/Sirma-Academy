namespace ShapeAreaCalculator.Models
{
    public abstract class Shape
    {
        public abstract double GetArea();

        public abstract double GetPerimeter();

        public static void ValidateSide(double sideValue, string sideName)
        {
            if (sideValue <= 0)
            {
                throw new Exception(string.Format($"Invalid {sideName}!"));
            }
        }

        public override string ToString()
        {
            return $"Shape {this.GetType().Name}:\nPerimeter: {this.GetPerimeter():F2}\nArea: {this.GetArea():F2}";
        }
    }
}
