namespace ShapeAreaCalculator.Models
{
    public class Triangle : Shape
    {
        private double side;
        private double height;

        public double Side
        {
            get => side;

            private set
            {
                ValidateSide(value, nameof(Side));
                side = value;
            }
        }
        public double Height
        {
            get => height;

            private set
            {
                ValidateSide(value, nameof(Height));
                height = value;
            }
        }

        public Triangle(double height, double width)
        {
            Side = width;
            Height = height;
        }


        public override double GetArea()
        {
            return Side * Height / 2;
        }

        public override double GetPerimeter()
        {
            return (3 * Side);
        }
    }
}
