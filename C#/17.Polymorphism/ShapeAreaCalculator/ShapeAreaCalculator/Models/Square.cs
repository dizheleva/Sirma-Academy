namespace ShapeAreaCalculator.Models
{
    using System;

    public class Square : Shape
    {
        private double side;
        public double Side
        {
            get => side;

            private set
            {
                ValidateSide(value, nameof(Side));
                side = value;
            }
        }

        public Square(double side)
        {
            Side = side;
        }

        public override double GetArea() => Math.Pow(Side, 2);

        public override double GetPerimeter() => 4 * Side;
    }
}
