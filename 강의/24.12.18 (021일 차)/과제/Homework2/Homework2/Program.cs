/*
날짜: 24.12.18
이름: 이시온
*/
/*
### 과제 2) 테란 유닛 큐

https://img.notionusercontent.com/s3/prod-files-secure%2Fecbfc15b-d9e9-421e-911d-a5bceae47cb4%2F29fef079-f8d9-455f-8fd7-956d3372f869%2Fimage.png/size/w=970?exp=1734590137&sig=zYzGbcS_YCdCe6X66Asry_HcVmtTsibqxlH3dMDP0s8

게임에서 적 캐릭터들이 순차적으로 생성되어 플레이어와 전투를 벌입니다. 전투 중인 적이 제거되면 다음 적이 등장하는 시스템을 구현합니다.

- **추상 테란유닛 클래스**
    - 유닛 이름 문자열
    - 유닛 체력 정수형
    - 유닛 공격 가능여부 불값
- **테란유닛 상속받는 마린 클래스**
    - 유닛 공격 가능여부 참
    - 메서드로 스팀팩
        - 유닛 체력을 10 깎음
        - 콘솔엔 “공속, 뎀지 일시 상승” 출력
- **테란유닛 상속받는 메딕 클래스**
    - 유닛 공격 가능 여부 거짓
    - 메서드로 옵티컬플레어
        - 콘솔에 “옵티컬플레어 사용” 출력
- **배럭 클래스**
    - 메딕이나 마린등을 담을 수 있는 Queue를 필드로 가짐.
    - 기능:
        - **EnqueueUnit** (string name, int health): 새로운 적을 큐에 추가합니다.
        - **DequeueUnit**: 큐에서 가장 먼저 등록된 유닛 출고
            - 유닛 생성 시, “유닛+name 생성되었음” 출력
        - **ShowQueueLine**: 현재 남아있는 대기열 유닛 이름 모두 출력
- **메인서 테스트**
    - 배럭을 새로 만듭니다
    - 여러 유닛을 **EnqueueUnit** 혹은 **DequeueUnit**을 통해 확인
*/

namespace Homework2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // 배럭을 새로 만듭니다
            Barracks barracks = new();

            // 여러 유닛을 **EnqueueUnit** 혹은 **DequeueUnit** 을 통해 확인
            barracks.EnqueueUnit("Marine", 50);

            barracks.EnqueueUnit("Medic", 70);

            barracks.EnqueueUnit("Marine", 40);

            barracks.EnqueueUnit("Medic", 60);

            barracks.EnqueueUnit("Marine", 30);

            barracks.EnqueueUnit("Medic", 50);
            
            while (barracks.QueueCount > 0)
            {
                var unit = barracks.DequeueUnit();

                (unit as Marine)?.StimPacks();

                (unit as Medic)?.OpticalFlare();

                barracks.ShowQueueLine();
            }
        }

        // 추상 테란유닛 클래스**
        public abstract class TerranUnit
        {
            // 유닛 이름 문자열
            public readonly string name;

            // 유닛 체력 정수형
            public readonly int hpMax;

            protected int hp;

            // 유닛 공격 가능여부 불값
            public readonly bool isAttackable;

            protected TerranUnit(string name, int hpMax, int hp, bool isAttackable)
            {
                this.name = name;

                this.hpMax = hpMax;

                this.hp = hp;

                if (hp > hpMax)
                {
                    hp = hpMax;
                }

                this.isAttackable = isAttackable;
            }
        }

        // 테란유닛 상속받는 마린 클래스.
        public sealed class Marine : TerranUnit
        {
            // 유닛 공격 가능여부 참.
            public Marine(int hp) : base("Marine", 40, hp, true) { }

            // 메서드로 스팀팩.
            public void StimPacks()
            {
                // 유닛 체력을 10 깎음.
                hp -= 10;

                // 콘솔엔 “공속, 뎀지 일시 상승” 출력.
                Console.WriteLine("\n공속, 데미지 일시 상승");
            }
        }

        // 테란유닛 상속받는 메딕 클래스.
        public sealed class Medic : TerranUnit
        {
            // 유닛 공격 가능 여부 거짓.
            public Medic(int hp) : base("Medic", 60, hp, false) { }

            // 메서드로 옵티컬플레어
            
            public void OpticalFlare()
            {
                // 콘솔에 “옵티컬플레어 사용” 출력
                Console.WriteLine("\n옵티컬플레어 사용");
            }
        }
        
        // 배럭 클래스
        public sealed class Barracks
        {
            // 메딕이나 마린등을 담을 수 있는 Queue를 필드로 가짐.
            private readonly Queue<TerranUnit> units = new();

            public int QueueCount => units.Count;

            // EnqueueUnit(string name, int health): 새로운 적을 큐에 추가합니다.
            public void EnqueueUnit(string name, int health)
            {
                if (name == "Marine")
                {
                    units.Enqueue(new Marine(health));
                }

                else if (name == "Medic")
                {
                    units.Enqueue(new Medic(health));
                }
            }

            // DequeueUnit: 큐에서 가장 먼저 등록된 유닛 출고
            public TerranUnit DequeueUnit()
            {
                var unit = units.Dequeue();

                // 유닛 생성 시, “유닛+name 생성되었음” 출력
                Console.WriteLine($"\n유닛 {unit.name} 생성되었음");

                return unit;
            }
            
            // ShowQueueLine: 현재 남아있는 대기열 유닛 이름 모두 출력
            public void ShowQueueLine()
            {
                Console.WriteLine("\n대기열 유닛:");

                foreach (var unit in units)
                {
                    Console.WriteLine(unit.name);
                }
            }
        }
    }
}