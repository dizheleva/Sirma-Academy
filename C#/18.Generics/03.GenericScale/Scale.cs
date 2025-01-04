namespace _03.GenericScale
{
    using System;

    public class Scale<T> where T : IComparable<T>
    {
        private readonly T left;
        private readonly T right;

        public Scale(T left, T right)
        {
            this.left = left;
            this.right = right;
        }

        public T GetHeavier()
        {
            if (this.left.CompareTo(this.right) > 0)
            {
                return this.left;
            }
            else if (this.left.CompareTo(this.right) < 0)
            {
                return this.right;
            }
            else
            {
                return default;
            }
        }
    }
}
