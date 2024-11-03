internal class Program
{
    private static void Main(string[] args)
    {
        Queue<int> firstPlayerHand = new Queue<int>();
        List<int> firstCards = Console.ReadLine().Split().Select(int.Parse).Distinct().ToList();
        firstCards.ForEach(card => firstPlayerHand.Enqueue(card));

        Queue<int> secondPlayerHand = new Queue<int>();
        List<int> secondCards = Console.ReadLine().Split().Select(int.Parse).Distinct().ToList();
        secondCards.ForEach(card => secondPlayerHand.Enqueue(card));

        const int rounds = 50;

        for (int i = 0; i < rounds && firstPlayerHand.Count > 0 && secondPlayerHand.Count > 0; i++)
        {
            int firstPlayerCard = firstPlayerHand.Dequeue();
            int secondPlayerCard = secondPlayerHand.Dequeue();

            if (firstPlayerCard > secondPlayerCard)
            {
                firstPlayerHand.Enqueue(firstPlayerCard);
                firstPlayerHand.Enqueue(secondPlayerCard);
            }
            else if (firstPlayerCard < secondPlayerCard)
            {
                secondPlayerHand.Enqueue(secondPlayerCard);
                secondPlayerHand.Enqueue(firstPlayerCard);
            }
            else
            {
                firstPlayerHand.Enqueue(firstPlayerCard);
                secondPlayerHand.Enqueue(secondPlayerCard);
            }
        }

        if (firstPlayerHand.Count == secondPlayerHand.Count)
        {
            Console.WriteLine("Draw!");
        }
        else
        {
            string winner = firstPlayerHand.Count > secondPlayerHand.Count ? "First" : "Second";
            Console.WriteLine($"{winner} player wins!");
        }
    }
}