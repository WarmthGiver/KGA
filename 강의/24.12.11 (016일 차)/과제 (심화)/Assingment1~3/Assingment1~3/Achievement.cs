using System;

namespace Assingment1_3
{
    public class Achievement
    {
        // 일반 필드

        // 업적 이름
        private string name;

        // 업적 설명
        private string description;

        // 목표 수치
        private int goal;

        // 현재 진행 수치 (기본값 0)
        private int progress = 0;

        // 업적 달성 여부 (기본값 false)
        private bool isCompleted = false;

        // static 필드

        // 생성된 업적의 총 개수를 저장하는 static 필드
        public static int totalAchievements = 0;

        // 달성된 업적의 총 개수를 저장하는 static 필드
        public static int completedAchievements = 0;

        // 생성자

        // 이름, 설명, 목표 수치를 받아 초기화
        // 생성자가 호출될 때마다 TotalAchievements를 증가.
        public Achievement(string name, string description, int goal)
        {
            this.name = name;

            this.description = description;

            this.goal = goal;

            ++totalAchievements;
        }

        // 메서드

        // AddProgress
        // 반환 없음.인자값으로 int value를 받음
        public void AddProgress(int value)
        {
            // Progress에 value를 더하고 목표 수치에 도달했는지 확인
            progress += value;

            // 목표를 달성하면,
            if (isCompleted == false && progress == goal)
            {
                // IsCompleted를 true로 설정.
                isCompleted = true;

                // CompletedAchievements를 1 증가.
                ++completedAchievements;

                // "업적 [업적 이름] 달성!" 출력.
                Console.WriteLine($"업적 [{name}] 달성!");

                Console.WriteLine();
            }
        }

        // DisplayInfo
        public void DisplayInfo()
        {
            // 업적 이름, 설명, 목표 및 진행 상황, 달성 여부를 출력
            Console.WriteLine($"이름: {name}");
            Console.WriteLine($"설명: {description}");
            Console.WriteLine($"목표: {goal}");
            Console.WriteLine($"진행 상황: {progress}");
            Console.WriteLine($"달성 여부: {isCompleted}");
        }

        // static 메서드

        // DisplaySummary
        public static void DisplaySummary()
        {
            // // 현재 생성된 업적의 총 개수와 달성된 업적의 총 개수를 출력
            Console.WriteLine($"업적의 총 개수: {totalAchievements}");
            Console.WriteLine($"달성된 업적의 총 개수: {completedAchievements}");
        }
    }
}