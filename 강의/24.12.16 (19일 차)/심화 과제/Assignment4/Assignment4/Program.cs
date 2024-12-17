/*
날짜: 24.12.16
이름: 이시온
*/
/*
### **심화 과제 ) 본인이 판단하는 자료구조**

Shape라는 Enum을 만들어서
Spade, Heart, Clover, Diamond 네 가지를 요소로 가지게 합니다.

Card라는 클래스를 만듭니다.
위 열거형을 Card클래스 맴버변수로 가지게 해주세요.
Card클래스에는 숫자를 나타내는 int형을 넣되, a는 1, J는 11, Q는 12, K는 13이라고 가정하겠습니다.

CardDeck이라는 클래스도 하나 제작하도록 하겠습니다.
Card 객체를 52개 담을 수 있는 ???(자료구조) 들을 활용하여 두 개 만드시되,
하나는 unusedCards, 하나는 usedCards 의 이름으로 만들겠습니다.

CardDeck 클래스의 생성자에 unusedCards 스택 속 52개의 Card를 중복없이 뉴할당해서 넣어주는 코드를 작성하여 주시기 바랍니다.
카드를 섞는 메소드를 작성하거나 생성자에서 바로 진행해주시기 바랍니다.

CardDeck 클래스에 맨 위 카드를 보기만 하는 ShowTopCard 기능을 제작하여 주시기 바랍니다.
이는 맨 상단의 카드를 보기만 할 뿐 카드를 소모하진 않습니다.

DrawCard라는 메소드도 하나 제작하겠습니다.
이 메소드는 덱의 맨 위 카드를 반환받고 그와 동시에 usedCard에 쌓는 기능을 수행합니다.
*/

namespace Assignment4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CardDeck cardDeck = new();

            Console.WriteLine(cardDeck.ShowTopCard()?.ToString());

            Console.WriteLine(cardDeck.DrawCard()?.ToString());

            Console.WriteLine(cardDeck.ShowTopCard()?.ToString());

            cardDeck.Shuffle();

            Console.WriteLine(cardDeck.ShowTopCard()?.ToString());
        }

        // Shape라는 Enum을 만들어서,
        public enum Shape
        {
            // Spade, Heart, Clover, Diamond 네 가지를 요소로 가지게 합니다.
            Spade,

            Diamond,

            Heart,
            
            Clover,
        }

        // Card라는 클래스를 만듭니다.
        public sealed class Card
        {
            // 위 열거형을 Card클래스 맴버변수로 가지게 해주세요.
            public readonly Shape shape;

            // Card클래스에는 숫자를 나타내는 int형을 넣되, a는 1, J는 11, Q는 12, K는 13이라고 가정하겠습니다.
            public readonly int number;

            public Card(Shape shape, int number)
            {
                this.shape = shape;

                this.number = number;
            }

            public override string ToString()
            {
                return $"{shape} {number}";
            }
        }

        // CardDeck이라는 클래스도 하나 제작하도록 하겠습니다.
        public sealed class CardDeck
        {
            // Card 객체를 52개 담을 수 있는 ???(자료구조) 들을 활용하여 두 개 만드시되, 하나는 unusedCards, 하나는 usedCards 의 이름으로 만들겠습니다.

            private const byte cardsCount = 52;

            private readonly List<Card> unusedCards = new(cardsCount);

            private byte unusedCardsPeek = cardsCount - 1;

            private readonly Card[] usedCards = new Card[cardsCount];

            private byte usedCardsPeek = 0;

            // CardDeck 클래스의 생성자에 unusedCards 스택 속 52개의 Card를 중복없이 뉴할당해서 넣어주는 코드를 작성하여 주시기 바랍니다.
            public CardDeck()
            {
                for (byte i = 1; i <= 13; ++i)
                {
                    unusedCards.Add(new(Shape.Spade, i));

                    unusedCards.Add(new(Shape.Diamond, i));

                    unusedCards.Add(new(Shape.Heart, i));

                    unusedCards.Add(new(Shape.Clover, i));
                }
            }

            // 카드를 섞는 메소드를 작성하거나 생성자에서 바로 진행해주시기 바랍니다.
            public void Shuffle()
            {
                Random random = new();

                for (byte i = 0; i < cardsCount; ++i)
                {
                    int r = random.Next(0, cardsCount);

                    Card temp = unusedCards[i];

                    unusedCards[i] = unusedCards[r];

                    unusedCards[r] = temp;
                }
            }

            // CardDeck 클래스에 맨 위 카드를 보기만 하는 ShowTopCard 기능을 제작하여 주시기 바랍니다.
            public Card? ShowTopCard()
            {
                // 이는 맨 상단의 카드를 보기만 할 뿐 카드를 소모하진 않습니다.
                if (unusedCardsPeek < 0)
                {
                    return null;
                }

                return unusedCards[unusedCardsPeek];
            }

            // DrawCard라는 메소드도 하나 제작하겠습니다.
            public Card? DrawCard()
            {
                if (unusedCardsPeek < 0)
                {
                    return null;
                }

                // 이 메소드는 덱의 맨 위 카드를 반환받고,
                Card card = unusedCards[unusedCardsPeek--];

                // 그와 동시에 usedCard에 쌓는 기능을 수행합니다.
                usedCards[usedCardsPeek++] = card;

                return card;
            }
        }
    }
}