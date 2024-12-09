using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    // Player라는 클래스를 새로운 cs에 만듭니다.
    public class Player
    {
        // 필드로 문자열형 이름, , 구조체 좌표(short형 x와 short형 y 두가지를 보유한 구조체), Inventory클래스로 만든 객체 하나를 보유하게 만듦.
        public string Name { get; set; }

        // 정수형 HP,
        public int HP { get; set; }

        // 정수형 공격력,
        public int Damage { get; set; }

        public Vector2 Position { get; set; }

        private Inventory inventory;

        public Inventory Inventory => inventory;

        // MakeInven의 이름으로 인벤토리를 뉴할당시키는 함수 하나 제작, 프로퍼티를 통해 인벤토리를 get하는 기능 제작
        public void MakeInven()
        {
            inventory = new Inventory();
        }

        public struct Vector2
        {
            public short X { get; set; }
            public short Y { get; set; }
        }
    }
}