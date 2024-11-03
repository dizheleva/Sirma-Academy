internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string, HashSet<Card>> hands = [];

        string command;
        while ((command = Console.ReadLine()) != "JOKER")
        {
            UpdateHands(hands, command);
        }

        foreach (var kvp in hands)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value.Sum(x => x.Power)}");
        }
    }

    private static void UpdateHands(Dictionary<string, HashSet<Card>> hands, string data)
    {
        var name = data.Split(": ")[0];
        var hand = data.Split(": ")[1].Split(", ").Select(x => new Card(x)).ToHashSet();

        if (!hands.ContainsKey(name))
        {
            hands.Add(name, []);
        }

        hands[name] = hands[name].Concat(hand).ToHashSet();
    }

    class Card 
    {
        public string Name;
        public string Value;
        public char Suit;
        public int Power;
        public static Dictionary<char, int> Suits = new() { { 'C', 1 }, { 'D', 2}, { 'H', 3 }, { 'S', 4 } };
        public static Dictionary<string, int> Values = new() { { "2", 2 }, { "3", 3 }, { "4", 4 }, { "5", 5 }, { "6", 6 }, { "7", 7 }, { "8", 8 }, { "9", 9 }, { "10", 10 }, { "J", 11 }, { "Q", 12 }, { "K", 13 }, { "A", 14 } };

        public Card(string name)
        {
            Name = name;
            Value = name.Substring(0, name.Length - 1);
            Suit = char.Parse(name.Substring(name.Length - 1)); 
            Power = Values[this.Value] * Suits[this.Suit];
        }

        public override bool Equals(object obj) => Equals(obj as Card);

        public bool Equals(Card other) => other != null && Name == other.Name;

        public override int GetHashCode() => HashCode.Combine(Name);
    }
}