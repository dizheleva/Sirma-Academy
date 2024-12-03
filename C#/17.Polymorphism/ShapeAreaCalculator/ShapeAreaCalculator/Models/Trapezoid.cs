namespace ShapeAreaCalculator.Models
{
    using System;
    using System.Text.Json.Serialization;

    public class Trapezoid : Shape
    {
        private double sideA;
        private double sideB;
        private double sideC;
        private double sideD;

        public double SideA
        {
            get => sideA;

            private set
            {
                ValidateSide(value, nameof(SideA));
                sideA = value;
            }
        }

        public double SideB
        {
            get => sideB;

            private set
            {
                ValidateSide(value, nameof(SideB));
                sideB = value;
            }
        }

        public double SideC
        {
            get => sideC;

            private set
            {
                ValidateSide(value, nameof(SideC));
                sideC = value;
            }
        }

        public double SideD
        {
            get => sideD;

            private set
            {
                ValidateSide(value, nameof(SideD));
                sideD = value;
            }
        }

        [JsonConstructorAttribute]
        public Trapezoid(double sideA, double sideB, double sideC, double sideD)
        {
            ValidateTrapezoid(sideA, sideB, sideC, sideD);
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            SideD = sideD;
        }
        public override double GetArea()
        {
            var s = GetPerimeter() / 2;
            return Math.Sqrt((s - SideA) * (s - SideB) * (s - SideB - SideC) * (s - SideB - SideD)) * (SideA + SideB) / Math.Abs(SideB - SideA);
        }
        public override double GetPerimeter() => SideA + SideB + SideC + SideD;

        public static void ValidateTrapezoid(double a, double b, double c, double d)
        {
            //start from the longest parallel side
            if (b + c + d - a <= 0 || a + c + d - b <= 0 || a + d - b - c <= 0 || a + c - b - d <= 0)
            {
                throw new Exception("Invalid Trapezoid!");
            }
        }
    }
}