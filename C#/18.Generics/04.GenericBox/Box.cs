namespace _04.GenericBox
{
    public class Box<T>
    {
        private T Value;

        public Box(T value)
        {
            this.Value = value;
        }

        public override string ToString()
        {
            return $"{this.Value.GetType().FullName}: {this.Value}";
        }
    }
}
