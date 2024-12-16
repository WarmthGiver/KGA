/*
날짜: 24.12.13
이름: 이시온
*/
/*
### 심화 과제) 근거리에 있을때만 상호 작용 가능하게 구현

플레이어는 상호작용 가능한 모든 NPC들과, 언제나 소통할 수 있는 건 아닙니다. 거리가 가까울때만 상호작용이 가능합니다. 이를 구현하기 위해 필요한 다양한 필드, 메서드, 프로퍼티등을 구현합니다.

- 메인서 다양한 종류의 NPC 를 만들고, 모든 NPC를 담은 NPC 배열을 하나 만듭니다
- 플레이어에게 **ShowInteractable** 이라는 메서드를 만들고 인자로 모든 NPC가 들어있는 배열을 받습니다.
    - 이 함수가 실행되면 플레이어와의 거리가 5 미만인 NPC들 중, 상호작용 가능한 NPC의 이름을 전부 출력하는 기능을 작성하세요.
- 플레이어 초기 x값은 5로 하고, NPC 중 하나는 x좌표가 3, 또 다른 하나는 x 좌표가 7, 또 다른 하나는 x가 12 등등 다양한 위치에 상호작용, 불가능한 npc를 두고 테스트 하는 코드를 작성합니다.

이를 구현하기 위해 as, is, 다형성, Math.Abs, 생성자, 오버로딩, 오버라이딩 등등 필요한 다양한 것을 추가하셔도 좋습니다.
*/
namespace Assignment1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // 메인서 다양한 종류의 NPC 를 만들고,
            EnchantNPC enchantNPC = new("대장장이");

            WarehouseNPC warehouseNPC = new("창고지기");

            FoolNPC npc = new("바보");

            // 모든 NPC를 담은 NPC 배열을 하나 만듭니다
            NPC[] npcs = [enchantNPC, warehouseNPC, npc];

            Player player = new();

            // 플레이어 초기 x값은 5로 하고,
            player.X = 5;

            // NPC 중 하나는 x좌표가 3,
            enchantNPC.X = 3;

            // 또 다른 하나는 x 좌표가 7,
            warehouseNPC.X = 7;

            // 또 다른 하나는 x가 12 등등 다양한 위치에 상호작용, 불가능한 npc를 두고 테스트 하는 코드를 작성합니다.
            npc.X = 12;

            player.ShowInteractable(npcs);
        }
    }

    public interface IInteractable
    {
        public void Interact();
    }

    public abstract class NPC : IInteractable
    {
        public int X { get; set; }

        public readonly string name;

        public NPC(string name)
        {
            this.name = name;
        }

        public abstract void Interact();
    }

    public sealed class EnchantNPC : NPC
    {
        public EnchantNPC(string name) : base(name) { }

        public override void Interact()
        {
            Console.WriteLine("강화 수행");
        }
    }

    public sealed class WarehouseNPC : NPC
    {
        public WarehouseNPC(string name) : base(name) { }

        public override void Interact()
        {
            Console.WriteLine("창고 상호작용");
        }
    }

    public sealed class FoolNPC : NPC
    {
        public FoolNPC(string name) : base(name) { }

        public override void Interact()
        {

        }
    }

    public sealed class Player
    {
        public int X { get; set; }

        public void InteractWithNPC(IInteractable npc)
        {
            npc.Interact();
        }

        // 플레이어에게 ShowInteractable이라는 메서드를 만들고 인자로 모든 NPC가 들어있는 배열을 받습니다.
        // // 이 함수가 실행되면,
        public void ShowInteractable(NPC[] npcs)
        {
            foreach (NPC npc in npcs)
            {
                int distance = X - npc.X;

                // 플레이어와의 거리가 5 미만인 NPC들 중,
                if (distance <= -5 || 5 <= distance)
                {
                    continue;
                }

                // 상호작용 가능한 NPC의 이름을 전부 출력하는 기능을 작성하세요.
                Console.WriteLine(npc.name);
            }
        }
    }
}