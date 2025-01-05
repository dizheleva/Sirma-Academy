namespace _04.InterfaceSegregationPrinciple.Player
{
    public class MyPlayer : IPlayer, IPauser, ISwitcher, IShuffler
    {
        public void Play()
        {
            Console.WriteLine("Playing...");
        }

        public void Pause()
        {
            Console.WriteLine("Pausing...");
        }

        public void Next()
        {
            Console.WriteLine("Changed to Next");
        }        

        public void Previous()
        {
            Console.WriteLine("Changed to Previous");
        }

        public void Shuffle()
        {            
            Console.WriteLine("Shuffling...");
        }
    }
}
