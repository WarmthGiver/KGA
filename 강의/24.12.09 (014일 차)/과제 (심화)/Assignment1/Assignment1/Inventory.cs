using System;

namespace Assignment1
{
    // Inventory라는 클래스를 새로운  cs 시트에 제작,
    public class Inventory
    {
        // 필드로 아이템 배열을 가지게 함.
        public Item?[]? items { get; private set; } = null;

        // 함수 내용은 아이템배열이 0보다 작거나 null일 경우 false, 존재한다면 true반환.
        public bool isInvenCreated => items != null && items.Length > 0;

        //인자값은 정수형 하나. 넘어온 인자값에 따라 아이템 배열을 할당해주고, 인자값만큼 인벤토리가 만들어졌다고 출력하는 기능 제작.
        public void CreateInvenBySize(int size)
        {
            items = new Item[size];
        }

        // 리턴값은 아이템, 함수 구현사항으로는 아이템 배열 중, 해당 인자값 위치의 아이템 반환하거나 비어있을 경우, null을 반환함과 동시에 비어있음 출력, 인자값은 정수형 인덱스.
        public Item? GetItemByIndex(int index)
        {
            if (items != null)
            {
                if (0 <= index && index < items.Length)
                {
                    if (items[index] != null)
                    {
                        return items[index];
                    }
                }
            }

            Console.WriteLine("비어있음");
            return null;
        }

        // 반환형은 없고, 인자값은 인덱스와 Item형 하나를 받는 함수 제작
        public void SetItemByIndex(int index, Item item)
        {
            if (items != null)
            {
                if (0 <= index && index < items.Length)
                {
                    items[index] = item;
                }
            }
        }
    }
}