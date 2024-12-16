/*
날짜: 24.12.13
이름: 이시온
*/
/*
### 과제 2) 인터페이스 구현

RPG 게임에 수많은 NPC가 있습니다. 어떤 NPC는 그냥 아무 기능 없이 가끔 랜덤한 시간에 대사를 뱉기도 하고, 특정 NPC는 플레이어와 G와 같은 키로 상호작용을 하여 강화 혹은 창고와 같은 기능을 수행할 수 있습니다.

다음 제작 요구사항에 맞추어 필요한 내용이 있다면 다양한 필드/프로퍼티/메소드를 추가하시면 됩니다. 클래스도 필요하다면 추가해주시기 바랍니다. 너무 이상한 거 있으면 물어봐주시기 바랍니다.

- **NPC 뼈대 클래스 작성**
    - 모든 NPC들이 상속받을 추상클래스를 하나 만듭니다.
    - 모든 NPC는 좌표 x를 가지고 있습니다.
    - 모든 NPC는 이름을 가지고 있습니다.
    
- **플레이어어와 상호작용 할 수 있는 특정 NPC들이 사용할 인터페이스 제작**
    - 이름은 IInteractable을 추천드립니다.
    - 이 인터페이스 속엔 Interact() 메서드를 선언합니다.
    - 추가적인 내용을 담고 싶다면 프로퍼티, 메서드를 더 넣습니다.
    
- **NPC 구현(모두 위에서 만든 추상클래스 하나를 상속받습니다)**
    - 강화 NPC: 플레이어와 상호작용 기능합니다. 상호작용을 수행 시, 강화를 수행한다는 관련 문자열을 출력합니다
    - 창고 NPC: 플레이어와 상호 작용 가능합니다. 상호작용을 수행 시, 창고 상호작용을 수행한다는 문자열을 출력합니다
    - 잡 NPC: 플레이어와 상호 작용은 없습니다. 그냥 존재합니다
    - 추가적으로 원하는 NPC를 자유 구현 합니다.

- **플레이어 구현**
    - Player 클래스를 만듭니다.
    - 플레이어는 x좌표를 하나 가지고 있습니다.
    - 플레이어가 여러 NPC와 상호작용할 수 있도록 **InteractWithNPC(IInteractable npc)** 메서드를 작성하세요.
        - 이 메서드는 전달된 NPC의 **Interact()**를 호출합니다.

- **검증**
    - 메인서 플레이어를 하나 만듭니다.
    - 세 NPC를 만듭니다.
    - 세 NPC를 한 번씩 플레이어의 InteractWithNPC의 인자값으로 넣어보고 가능한지 테스트 해봅니다.
*/
using System.Numerics;

namespace Homework2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // 메인서 플레이어를 하나 만듭니다.
            Player player = new();

            // 세 NPC를 만듭니다.
            EnchantNPC enchantNpc = new();

            WarehouseNPC warehouseNPC = new();

            NPC npc = new();

            // 세 NPC를 한 번씩 플레이어의 InteractWithNPC의 인자값으로 넣어보고 가능한지 테스트 해봅니다.
            player.InteractWithNPC(enchantNpc);

            player.InteractWithNPC(warehouseNPC);

            player.InteractWithNPC(npc);
        }
    }

    // 플레이어어와 상호작용 할 수 있는 특정 NPC들이 사용할 인터페이스 제작**
    // 이름은 IInteractable을 추천드립니다.
    public interface IInteractable
    {
        // 이 인터페이스 속엔 Interact() 메서드를 선언합니다.
        public void Interact();
    }

    // NPC 뼈대 클래스 작성
    // 모든 NPC들이 상속받을 추상클래스를 하나 만듭니다.
    public abstract class Charactor : IInteractable
    {
        // 모든 NPC는 좌표 x를 가지고 있습니다.
        public int X { get; set; }

        // 모든 NPC는 이름을 가지고 있습니다.
        public readonly string name;

        public abstract void Interact();
    }

    // NPC 구현 (모두 위에서 만든 추상클래스 하나를 상속받습니다.)
    // 강화 NPC: 플레이어와 상호작용 기능합니다.상호작용을 수행 시, 강화를 수행한다는 관련 문자열을 출력합니다.
    public sealed class EnchantNPC : Charactor
    {
        public override void Interact()
        {
            Console.WriteLine("강화 수행");
        }
    }

    // 창고 NPC: 플레이어와 상호 작용 가능합니다.상호작용을 수행 시, 창고 상호작용을 수행한다는 문자열을 출력합니다.
    public sealed class WarehouseNPC : Charactor
    {
        public override void Interact()
        {
            Console.WriteLine("창고 상호작용");
        }
    }

    // 잡 NPC: 플레이어와 상호 작용은 없습니다. 그냥 존재합니다.
    public sealed class NPC : Charactor
    {
        public override void Interact()
        {

        }
    }

    // 플레이어 구현**
    // Player 클래스를 만듭니다.
    public sealed class Player
    {
        // 플레이어는 x좌표를 하나 가지고 있습니다.
        public int X { get; set; }

        // 플레이어가 여러 NPC와 상호작용할 수 있도록 InteractWithNPC(IInteractable npc) 메서드를 작성하세요.
        // 이 메서드는 전달된 NPC의 Interact()를 호출합니다.
        public void InteractWithNPC(IInteractable npc)
        {
            npc.Interact();
        }
    }
}