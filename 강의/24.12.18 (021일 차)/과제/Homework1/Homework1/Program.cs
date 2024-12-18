/*
날짜: 24.12.18
이름: 이시온
*/
/*
### 과제 1) 버프/디버프 시스템

https://img.notionusercontent.com/s3/prod-files-secure%2Fecbfc15b-d9e9-421e-911d-a5bceae47cb4%2F5499d885-a616-4fd7-88a2-1986709f0ec1%2Fimage.png/size/w=1360?exp=1734590191&sig=8OryhVOp_k_xkq1_4-hHp_Q09DllG2p6scX_uEfqDNY

게임 캐릭터가 여러 개의 **버프/디버프** 효과를 받을 수 있습니다. 각 효과는 지속 시간이 있으며, 시간이 지남에 따라 종료됩니다. 잦은 추가, 삭제가 이루어 집니다.

- **Buff 클래스 제작**
    - 버프의 이름을 담을 문자열 필드
    - 버프의 지속시간을 담을 정수형 필드
    - 생성자를 작성하여 위 필드를 초기화 진행
- **BuffManager 클래스**
    - 필드로 LinkedList<Buff> 를 가지게 함
    - 구현해야 할 메서드들
        - **AddBuff**(string name, int duration): 새로운 버프를 링크드리스트에 추가합니다.
        - **UpdateBuffs**: 모든 버프의 지속 시간을 1 감소시키고, 지속 시간이 0인 버프는 제거합니다.
            - 제거될 때 버프 이름과 **"효과 종료"** 메시지를 출력합니다.
        - **ShowActiveBuffs**: 현재 활성화된 모든 버프의 이름과 남은 지속 시간을 출력합니다.

- **메인서 테스트 해보기**
    - BuffManager 객체를 생성하고 다양한 버프를 추가합니다.
    - **AddBuff → UpdateBuffs → ShowActiveBuffs** 등등을 자유롭게 여러 번 시도 해보면서 버프가 순차적으로 사라지는 과정을 확인합니다.
*/

namespace Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // BuffManager 객체를 생성하고 다양한 버프를 추가합니다.
            BuffManager buffManager = new();

            // **AddBuff → UpdateBuffs → ShowActiveBuffs** 등등을 자유롭게 여러 번 시도 해보면서 버프가 순차적으로 사라지는 과정을 확인합니다.
            buffManager.AddBuff("A", 5);

            buffManager.AddBuff("B", 1);

            buffManager.AddBuff("C", 3);

            buffManager.AddBuff("D", 2);

            while (buffManager.BuffsCount > 0)
            {
                buffManager.ShowActiveBuffs();

                buffManager.UpdateBuffs();
            }
        }
    }

    // Buff 클래스 제작
    public sealed class Buff
    {
        // 버프의 이름을 담을 문자열 필드
        public readonly string name;

        // 버프의 지속시간을 담을 정수형 필드
        public readonly int duration;

        private int time;

        // 생성자를 작성하여 위 필드를 초기화 진행
        public Buff(string name, int duration)
        {
            this.name = name;

            this.duration = duration;

            time = duration;
        }

        public bool Update()
        {
            return --time > 0;
        }

        public override string ToString()
        {
            return $"이름: {name}, 남은 시간: {time}";
        }
    }

    // BuffManager 클래스
    public sealed class BuffManager
    {
        // 필드로 LinkedList<Buff> 를 가지게 함
        private readonly LinkedList<Buff> buffs = new();

        public int BuffsCount => buffs.Count;

        // AddBuff(string name, int duration): 새로운 버프를 링크드리스트에 추가합니다.
        public void AddBuff(string name, int duration)
        {
            buffs.AddLast(new Buff(name, duration));
        }

        // UpdateBuffs: 모든 버프의 지속 시간을 1 감소시키고, 지속 시간이 0인 버프는 제거합니다.
        public void UpdateBuffs()
        {
            Console.WriteLine("\n----------1초 후----------");

            var current = buffs.First;

            while (current != null)
            {
                if (current.Value.Update() == false)
                {
                    var old = current;

                    current = old.Next;

                    buffs.Remove(old);

                    // 제거될 때 버프 이름과 **"효과 종료"** 메시지를 출력합니다.
                    Console.WriteLine($"\n{old.Value.name} 효과 종료");
                }

                else
                {
                    current = current.Next;
                }
            }
        }

        // ShowActiveBuffs: 현재 활성화된 모든 버프의 이름과 남은 지속 시간을 출력합니다.
        public void ShowActiveBuffs()
        {
            Console.WriteLine("\n활성화 버프:");

            foreach (var buff in buffs)
            {
                Console.WriteLine(buff);
            }
        }
    }
}