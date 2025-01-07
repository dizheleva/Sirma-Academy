namespace Factory
{
    public class ShapeFactory
    {
        public IShape GetShape(string shapeType)
        {
            if (string.IsNullOrEmpty(shapeType))
            {
                throw new ArgumentException("Invalid shape!");
            }

            return shapeType.ToLower() switch
            {
                "circle" => new Circle(),
                "rectangle" => new Rectangle(),
                "square" => new Square(),
                _ => throw new ArgumentException("Invalid shape!"),
            };
        }
    }
}
