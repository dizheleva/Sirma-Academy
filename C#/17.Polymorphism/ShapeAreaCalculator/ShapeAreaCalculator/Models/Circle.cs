namespace ShapeAreaCalculator.Models
{
    using System;

    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius
        {
            get => radius;

            private set
            {
                ValidateSide(value, nameof(Radius));
                radius = value;
            }
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
