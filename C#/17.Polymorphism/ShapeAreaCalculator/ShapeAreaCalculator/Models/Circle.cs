namespace ShapeAreaCalculator.Models
{
    using System;
    using System.Text.Json.Serialization;

    public class Circle : Shape
    {
        private double radius;

        [JsonConstructorAttribute]
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

        public override double GetArea() => Math.PI * Math.Pow(Radius, 2);

        public override double GetPerimeter() => Math.PI * 2 * Radius;
    }
}
