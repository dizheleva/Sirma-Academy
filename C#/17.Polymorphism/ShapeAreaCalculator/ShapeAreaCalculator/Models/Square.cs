namespace ShapeAreaCalculator.Models
{
    using System;
    using System.Text.Json.Serialization;

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

        [JsonConstructorAttribute]
        public Square(double side)
        {
            Side = side;
        }

        public override double GetArea() => Math.Pow(Side, 2);

        public override double GetPerimeter() => 4 * Side;
    }
}
