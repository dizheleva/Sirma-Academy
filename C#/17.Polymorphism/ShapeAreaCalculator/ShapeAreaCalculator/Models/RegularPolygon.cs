namespace ShapeAreaCalculator.Models
{
    using System;

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


        public RegularPolygon(int sidesCount, double side)
        {
            SidesCount = sidesCount;
            Side = side;
        }
        public override double GetArea()
        {
            return Side * Side * SidesCount / (4 * Math.Tan(180 / SidesCount));
        }
        public override double GetPerimeter() => Side * SidesCount;

        public static void ValidateSidesCount(int sidesCount)
        {
            if (sidesCount < 3)
            {
                throw new Exception(string.Format($"Invalid sides count!"));
            }
        }
    }
}
