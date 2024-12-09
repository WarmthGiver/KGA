namespace Assignment1
{
    // Item이라는 클래스를 따로 제작.
    public class Item
    {
        // 필드형으로는 ???형 아이템 이름
        public string Name { get; set; }

        // ??형 아이템타입
        public ItemType Type { get; set; }

        // ??? 형 가격
        public int Price { get; set; }

        public override string ToString()
        {
            return
                $"이름: {Name}\n" +
                $"타입: {Type}\n" +
                $"가격: {Price}";
        }
    }

    public enum ItemType
    {
        무기,
        방패,
        소모품,
    }
}