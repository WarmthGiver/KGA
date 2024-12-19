namespace ShuffleAndSort
{
    public sealed class Card
    {
        // 모든 트럼프 카드가 공유하는 문양과 문자를 저장하는 배열.
        // shape와 number를 인덱스로 접근하여 해당 문양과 문자를 받아와 콘솔에 출력할 때 사용.
        public static readonly char[] shapeChars = ['♤', '◇', '♡', '♧'];

        // 10은 로마 숫자 X로 표현.
        public static readonly char[] numberChars = ['0', 'A', '2', '3', '4', '5', '6', '7', '8', '9', 'X', 'J', 'Q', 'K'];

        public readonly Shape shape;

        public readonly int number;

        public Card(Shape shape, int number)
        {
            this.shape = shape;

            this.number = number;
        }

        public string Show()
        {
            return $"{shapeChars[(int)shape]}{numberChars[number]}";
        }
    }
}