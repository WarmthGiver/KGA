namespace Assignment1
{
    // Car라는 클래스를 만든 후,
    public class Car
    {
        // 필드로 문자열 차이름,
        public string Name { get; set; }

        // 정수형 자동차넘버
        public int number { get; set; }

        // 정수형 자동차체력
        private int hp;
        public int HP
        {
            get => hp;
            set
            {
                hp = value;

                if (hp < 0)
                {
                    hp = 0;
                }
            }
        }
    }
}