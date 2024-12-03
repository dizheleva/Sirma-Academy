namespace ShapeAreaCalculator.Models
{
    public abstract class Shape
    {
        public string Type { get; set; }

        protected Shape()
        {
            Type = GetType().Name;
        }
        public abstract double GetArea();

        public abstract double GetPerimeter();

        public static double ValidateSide(double sideValue, string sideName)
        {
            if (sideValue <= 0)
            {
                throw new Exception(string.Format($"Invalid {sideName}!"));
            }

            return sideValue;
        }

        public override string ToString()
        {
            return $"Shape {this.GetType().Name}:\nPerimeter: {this.GetPerimeter():F2}\nArea: {this.GetArea():F2}";
        }
    }
}
