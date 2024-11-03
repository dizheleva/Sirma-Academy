namespace _06.RandomizeWords
{
    public class Randomizer
    {
        private readonly Random random = new Random();
        public List<string> Randomize(List<string> list)
        {
            List<string> shuffledList = list.OrderBy(item => random.Next()).ToList();
            return shuffledList;
        }
    }
}
