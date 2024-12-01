namespace ShapeAreaCalculator.Models
{
    using System;

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

        public Trapezoid(double sideA, double sideB, double sideC, double sideD)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            SideD = sideD;
        }
        public override double GetArea()
        {
            //Heron's formula:
            var s = GetPerimeter() / 2;
            return Math.Sqrt((s - SideA) * (s - SideB) * (s - SideB - SideC) * (s - SideB - SideD)) * (SideA + SideB) / Math.Abs(SideB - SideA);
        }
        public override double GetPerimeter() => SideA + SideB + SideC + SideD;
    }
}