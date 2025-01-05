namespace Demo.CatsDemo
{
    public class Cat : IComparable<Cat>
    {
        public Cat(int age, int weight, string name)
        {
            Age = age;
            Weight = weight;
            Name = name;
        }

        public int Age { get; set; }
        public int Weight { get; set; }
        public string Name { get; set; }

        public int CompareTo(Cat? other)
        {

            if (other == null || Age > other.Age)
            {
                return 1;
            }
            else if (Age < other.Age)
            {
                return -1;
            }

            return 0;
        }
    }
}
