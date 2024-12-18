namespace Assignment4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CardDeck cardDeck = new();

            cardDeck.WriteAllCards();

            cardDeck.Shuffle();

            Console.WriteLine("\nShuffle()\n");

            cardDeck.WriteAllCards();

            cardDeck.Sort();

            Console.WriteLine("\nSort()\n");

            cardDeck.WriteAllCards();
        }
    }
}