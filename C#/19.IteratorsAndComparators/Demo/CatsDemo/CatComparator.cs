namespace Demo.CatsDemo
{
    public class CatComparator : IComparer<Cat>
    {
        public int Compare(Cat? x, Cat? y)
        {
            if (x == null || y == null)
            {
                return -1;
            }

            // Example comparison logic: compare by Age, then by Weight, then by Name
            var ageComparison = x.Age.CompareTo(y.Age);
            if (ageComparison != 0) return ageComparison;

            var weightComparison = x.Weight.CompareTo(y.Weight);
            if (weightComparison != 0) return weightComparison;

            return string.Compare(x.Name, y.Name, StringComparison.Ordinal);
        }
    }
}
