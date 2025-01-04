namespace _07.GenericSwapMethodIntegers
{
    using System.Collections.Generic;

    public class Swapper<T>
    {
        private List<Box<T>> Boxes { get; set; }

        public Swapper()
        {
            this.Boxes = [];
        }

        public List<Box<T>> Swap(List<T> items, int firstIndex, int secondIndex)
        {            
            var first = items[firstIndex];
            var second = items[secondIndex];

            foreach (var item in items)
            {
                if (item.Equals(first))
                {
                    Boxes.Add(new Box<T>(second));
                }
                else if (item.Equals(second))
                {
                    Boxes.Add(new Box<T>(first));
                }
                else
                {
                    Boxes.Add(new Box<T>(item));
                }
            }

            return Boxes;
        }
    }
}
