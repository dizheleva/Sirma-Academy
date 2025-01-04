namespace _07.GenericSwapMethodIntegers
{
    public class Box<T>
    {
        private T Value { get; set; }

        public Box(T value)
        {
            this.Value = value;
        }
                
        public override string ToString()
        {
            return $"{Value.GetType().FullName}: {Value}";
        }
    }
}
