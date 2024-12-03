namespace ShapeAreaCalculator.Models
{
    using System.Text.Json.Serialization;

    public class Triangle : Shape
    {
        private double sideA;
        private double sideB;
        private double sideC;

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

        [JsonConstructorAttribute]
        public Triangle(double sideA, double sideB, double sideC)
        {
            ValidateTriangle(sideA, sideB, sideC);
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }


        public override double GetArea()
        {
            //Heron's formula:
            var s = GetPerimeter() / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }

        public override double GetPerimeter() => SideA + SideB + SideC;

        public static void ValidateTriangle(double a, double b, double c)
        {
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                throw new Exception("Invalid triangle!");
            }
        }
    }
}
