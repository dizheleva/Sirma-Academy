namespace ShapeAreaCalculator.Models
{
    using System;
    using System.Text.Json.Serialization;

    public class RegularPolygon : Shape
    {
        private int sidesCount;
        private double side;

        public int SidesCount
        {
            get => sidesCount;

            private set
            {
                ValidateSidesCount(value);
                sidesCount = value;
            }
        }

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
        public RegularPolygon(int sidesCount, double side)
        {
            ValidatePolygon(sidesCount);
            SidesCount = sidesCount;
            Side = side;
        }
        public override double GetArea()
        {
            return (Side * Side * SidesCount) / (4 * Math.Tan(Math.PI / SidesCount));
        }
        public override double GetPerimeter() => Side * SidesCount;

        public static void ValidateSidesCount(int sidesCount)
        {
            if (sidesCount < 3)
            {
                throw new Exception(string.Format($"Invalid sides count!"));
            }
        }

        public static void ValidatePolygon(int sidesCount)
        {
            if (Math.Tan(Math.PI / sidesCount) <= 0)
            {
                throw new Exception("Invalid Plygon!");
            }
        }
    }
}
