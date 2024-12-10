using System;

namespace Assignment1
{
    // Game이라는 클래스를 새로운 cs에 작성.
    internal class Game
    {
        // Game 클래스는 맴버변수로 Hero 하나와 Monster 하나를 가짐.
        private Hero hero;

        private Monster monster;

        // Game 클래스는 생성과 동시에 Hero 와 Monster에 각각 뉴할당을 함.
        public Game()
        {
            // Hero는 이름 "Archer", 체력 100, 공격력 30, 방어력 5 로 세팅.
            hero = new Hero("Archer", 100, 30, 5);

            // Monster는 이름 "Skeleton", 체력 50, 공격력 20, 방어력 5, 레벨은 1로 세팅.
            monster = new Monster("Skeleton", 50, 20, 5, 1);
        }

        // Play라는 메서드 작성(반환X, 인자X).
        public void Play()
        {
            // 일단 게임이 시작되었다는 cw 출력.
            Console.WriteLine("게임 시작");

            Console.WriteLine();

            // Game이 들고있는 영웅과 몹의 체력이 둘 다 0 이상이라면 무한 반복 시작.
            while (true)
            {
                // 무한 반복을 하며, 사용자에게 다음 행동을 물어봄.

                // 다음 행동으로 무엇을 하시겠습니까? (1혹은2 입력 후 엔터)
                Console.WriteLine("다음 행동으로 무엇을 하시겠습니까?");

                // 1.영웅이 몬스터를 공격
                Console.WriteLine("1.영웅이 몬스터를 공격");

                // 2.몬스터가 영웅 공격
                Console.WriteLine("2.몬스터가 영웅 공격");

                while (true)
                {
                    Console.WriteLine();

                    int.TryParse(Console.ReadLine(), out var number);

                    // 만약 1번이 입력되었다면 영웅이 몹 공격하는 로직 실행.
                    if (number == 1)
                    {
                        hero.AttackMob(monster);

                        break;
                    }

                    // // 2번이 입력되었다면 몹이 영웅 치는 로직 실행
                    else if (number == 2)
                    {
                        monster.AttackHero(hero);

                        break;
                    }

                    // // 1,2 가 아닌 입력값 들어오면 제대로 다시 입력하라고 출력 후 다시 입력받음
                    Console.WriteLine("다시 입력하세요.");
                }

                // 1 혹은 2가 정상 수행되었다면, 이후 영웅과 몹의 상태 보여주는 메서드 각각 실행
                Console.WriteLine();

                hero.DisplayInfo();

                Console.WriteLine();

                monster.DisplayInfo();

                Console.WriteLine();

                // 만약 영웅 체력이 0 이하면 “영웅 사망으로 종료” 출력 후 무한루프 탈출.
                if (hero.HP == 0)
                {
                    Console.WriteLine("영웅 사망으로 종료");

                    break;
                }

                // 만약 몹 체력이 0 이하면 “몹 사망으로 종료” 출력 후 무한루프 탈출
                if (monster.HP == 0)
                {
                    Console.WriteLine("몹 사망으로 종료");

                    break;
                }

                // 위 내용을 구현하면서 만약 Hero나 Monster쪽에 추가로 필요한 메서드나 프로퍼티가 있다면 자유롭게 추가해보기(0 이하 처리 등등)
            }
        }
    }
}