namespace _10.CustomList
{
    using System;

    public class CustomList<T> where T : IComparable
    {
        private readonly int defaultCapacity = 10;
        private T[] Items { get; set; }

        private int Count { get; set; } = 0;

        public CustomList()
        {
            this.Items = new T[this.defaultCapacity];
        }

        public void Add(T element)
        {
            this.Count++;

            if (this.Count > this.defaultCapacity)
            {
                var newItems = new T[this.Count];

                for (var i = 0; i < this.Count - 2; i++)
                {
                    newItems[i] = this.Items[i];
                }
                this.Items = newItems;
            }

            this.Items[this.Count - 1] = element;
        }

        public T Remove(int index)
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("The list is empty!");
            }

            if (index < 0 || index > this.Count - 1)
            {
                throw new InvalidOperationException("Invalid index!");
            }

            T element = this.Items[index];                        
            this.Count--;

            var newItems = new T[this.Count];
            Array.Copy(this.Items, 0, newItems, 0, index);
            Array.Copy(this.Items, index + 1, newItems, index, this.Count - index);
            this.Items = newItems;

            return element;
        }

        public bool Contains(T element) => this.Items.Contains(element);

        public void Swap(int firstIndex, int secondIndex)
        {
            if (firstIndex < 0 || firstIndex > this.Count - 1 || secondIndex < 0 || secondIndex > this.Count - 1)
            {
                throw new InvalidOperationException("Invalid index!");
            }

            if (firstIndex == secondIndex)
            {
                return;
            }

            var first = this.Items[firstIndex];

            this.Items[firstIndex] = this.Items[secondIndex];
            this.Items[secondIndex] = first;
        }

        public int CountGreaterThan(T element)
        {
            var count = 0;

            foreach (var item in this.Items)
            {
                if (item != null && item.CompareTo(element) > 0)
                {
                    count++;
                }
            }

            return count;
        }

        public T GetMax() => this.Items.Max();

        public T GetMin() => this.Items.Min();

        public override string ToString()
        {
            return string.Join(Environment.NewLine, this.Items).TrimEnd();
        }
    }
}