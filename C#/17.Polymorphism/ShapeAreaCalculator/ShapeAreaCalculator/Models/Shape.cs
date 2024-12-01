namespace ShapeAreaCalculator.Models
{
    public abstract class Shape
    {
        public abstract double GetArea();

        public abstract double GetPerimeter();

        public void ValidateSide(double sideValue, string sideName)
        {
            if (sideValue <= 0)
            {
                throw new Exception(string.Format($"Invalid {sideName}!"));
            }
        }
    }
}
