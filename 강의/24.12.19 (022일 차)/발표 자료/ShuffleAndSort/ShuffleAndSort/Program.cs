namespace ShuffleAndSort
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CardDeck cardDeck = new();

            Console.WriteLine("\n셔플 전:\n");

            cardDeck.WriteAllCards();

            while (true)
            {
                var key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.Escape)
                {
                    break;
                }

                Console.Clear();

                Console.WriteLine("\n셔플 후:\n");

                cardDeck.Shuffle();

                cardDeck.WriteAllCards();
            }

            Console.Clear();

            Console.WriteLine("\n정렬 후:\n");

            cardDeck.Sort();

            cardDeck.WriteAllCards();

            Console.ReadKey(true);
        }
    }
}