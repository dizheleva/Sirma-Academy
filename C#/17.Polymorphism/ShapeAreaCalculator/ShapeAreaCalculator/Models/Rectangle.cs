namespace ShapeAreaCalculator.Models
{
    internal class Rectangle : Shape
    {
        private double sideA;
        private double sideB;

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

        public Rectangle(double sideA, double sideB)
        {
            SideA = sideA;
            SideB = sideB;
        }


        public override double GetArea() => SideA * SideB;

        public override double GetPerimeter() => (SideA + SideB) * 2;
    }
}
