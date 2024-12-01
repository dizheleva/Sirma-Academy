namespace ShapeAreaCalculator.Models
{
    internal class Rectangle : Shape
    {
        private double width;
        private double height;

        public double Width
        {
            get => width;

            private set
            {
                ValidateSide(value, nameof(Width));
                width = value;
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

        public Rectangle(double height, double width)
        {
            Width = width;
            Height = height;
        }


        public override double GetArea()
        {
            return Width * Height;
        }

        public override double GetPerimeter()
        {
            return (Width + Height) * 2; 
        }
    }
}
