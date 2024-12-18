﻿namespace Assignment4
{
    public sealed class CardDeck
    {
        // List는 Add를 했을 때 배열의 크기를 초과하면 2배 크기의 배열을 새로 생성하고 기존 데이터를 복사.
        // 이는 성능 저하와 가비지를 발생할 수 있으므로 미리 배열의 크기를 할당하는 것이 좋음.
        // 트럼프 카드는 52장이 최대이므로 52칸의 크기를 미리 할당.
        private readonly List<Card> unusedCards = new(52);

        private readonly List<Card> usedCards = new(52);

        // 덱을 섞을 때 재사용할 수 있게 멤버 변수로 선언.
        private readonly Random random = new();

        public CardDeck()
        {
            for (int i = 1; i <= 13; ++i)
            {
                for (int j = 0; j < (int)Shape.Length; ++j)
                {
                    unusedCards.Add(new((Shape)j, i));
                }
            }
        }

        // 피셔-예이츠 섞기 알고리즘(Fisher-Yates Suffle Algorithm)
        public void Shuffle()
        {
            for (int i = unusedCards.Count; i > 1;)
            {
                int j = random.Next(0, i--);

                Card temp = unusedCards[i];

                unusedCards[i] = unusedCards[j];

                unusedCards[j] = temp;
            }
        }

        // 선택 정렬(Selection Sort)
        public void Sort()
        {
            for (int i = 0; i < unusedCards.Count; ++i)
            {
                int j = i;

                for (int k = j + 1; k < unusedCards.Count; ++k)
                {
                    // 만약 비교한 카드의 숫자가 더 작다면,
                    if (unusedCards[j].number > unusedCards[k].number)
                    {
                        // j에 카드 인덱스 저장.
                        j = k;
                    }

                    // 만약 비교한 카드의 숫자가 같다면,
                    if (unusedCards[j].number == unusedCards[k].number)
                    {
                        // 카드의 문양을 비교하고, 비교한 카드의 문양이 더 작다면,
                        if (unusedCards[j].shape > unusedCards[k].shape)
                        {
                            // j에 카드 인덱스 저장.
                            j = k;
                        }
                    }
                }

                // 찾은 가장 작은 값(j번째)을 i번째와 교환.
                Card temp = unusedCards[i];

                unusedCards[i] = unusedCards[j];

                unusedCards[j] = temp;
            }
        }

        public Card? ShowTopCard()
        {
            if (unusedCards.Count == 0)
            {
                return null;
            }

            // Last()
            // 컬렉션의 마지막 요소를 가져오는 함수.
            // System.Linq 확장 메서드.
            return unusedCards.Last();
        }

        public Card? DrawCard()
        {
            if (unusedCards.Count == 0)
            {
                return null;
            }

            Card card = unusedCards.Last();

            unusedCards.RemoveAt(unusedCards.Count - 1);

            usedCards.Add(card);

            return card;
        }

        public void WriteAllCards()
        {
            foreach (var card in unusedCards)
            {
                Console.WriteLine(card.Show());
            }
        }
    }
}