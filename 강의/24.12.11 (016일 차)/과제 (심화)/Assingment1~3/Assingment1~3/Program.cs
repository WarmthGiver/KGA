/*
날짜: 24.12.11
이름: 이시온
*/
/*
## **심화 과제 1)**

Math와 같은 클래스는 객체를 만들지 않고도 기능들을 만들어 사용할 수 있음을 배웠습니다.
편리한 사용을 위해 본인만의 myHelper 라는 클래스를 만들었다고 가정하겠습니다.
정수 배열을 입력받아 해당 배열의 요소들 중에서 가장 작은 값을 반환하는 정적 메소드를 하나 작성하세요.
요구 사항은 아래와 같습니다.

- 입력으로 주어지는 배열은 비어있지 않다고 가정합니다.
- 정적(static) 메서드를 사용하여 구현하여야 합니다
- 배열의 모든 요소를 반복하여 가장 작은 값을 찾아 반환하여야 합니다.

```csharp
class myHelper
{
    FindMinimum //여기 작성
    {
        //함수 내부 구현
    }
}
```
*/
/*
## **심화 과제 2)**

위의 myHelper 클래스에 정적 메소드를 하나 더 만들겠습니다.
주어진 문자열에서 대문자의 개수를 세는 정적 메소드를 구현하세요.
요구 사항은 아래와 같습니다.

- 입력으로 주어지는 문자열은 비어있지 않다고 가정하겠습니다.
- 정적 메서드를 사용하여 구현하여야 합니다.
- 문자열을 반복하여 대문자의 개수를 세고, 그 개수를 반환하여야 합니다.
- char형의 내장 기능 중, IsUpper를 활용하면 대문자 여부를 확인 가능합니다.

```csharp
class myHelper
{
    FindMinimum //심화 1번
    {
        //심화 1번 함수 내부 구현
    }

    CountUppercaseLetters //심화 2번
    {
        //심화 2번 함수 내부 구현
    }
}
```
*/
/*
## 심화 과제 3) 업적 시스템

새로운 cs 파일을 만들고, Achievement 클래스를 생성. 아래 구현 사항을 보다가 필요해보이는 내용이 발견되면 자유롭게 추가 구현 ㄱㄱ

**일반 필드 및 프로퍼티**

- string Name: 업적 이름
- string Description: 업적 설명
- int Goal: 목표 수치
- int Progress: 현재 진행 수치 (기본값 0)
- bool IsCompleted: 업적 달성 여부 (기본값 false)

**static 필드**

- int TotalAchievements: 생성된 업적의 총 개수를 저장하는 static 필드
- int CompletedAchievements: 달성된 업적의 총 개수를 저장하는 static 필드

**생성자**

- 이름, 설명, 목표 수치를 받아 초기화
- 생성자가 호출될 때마다 TotalAchievements를 증가.

**메서드**

- **AddProgress**
    - 반환 없음. 인자값으로 int value를 받음
    - Progress에 value를 더하고 목표 수치에 도달했는지 확인
    - 목표를 달성하면:
        - IsCompleted를 true로 설정.
        - CompletedAchievements를 1 증가.
        - "업적 [업적 이름] 달성!" 출력.
- **DisplayInfo**
    - 업적 이름, 설명, 목표 및 진행 상황, 달성 여부를 출력
    - 본인 취향껏
- **static 메서드: DisplaySummary**
    - 반환 없음
    - 현재 생성된 업적의 총 개수와 달성된 업적의 총 개수를 출력
    
- 테스트를 위해 메인으로 이동하여 다음을 작성
- Achievement 객체를 3개 생성
    - 첫 번째 업적: "초급 도전자", "점수 100점 달성", 목표 100
    - 두 번째 업적: "중급 도전자", "점수 500점 달성", 목표 500
    - 세 번째 업적: "고급 도전자", "점수 1000점 달성", 목표 1000
- 각 업적의 AddProgress 메서드를 호출하여 진행 상황을 업데이트:
    - 첫 번째 업적에 AddProgress 인자값으로 100
    - 두 번째 업적에  AddProgress 인자값으로 600
    - 세 번째 업적에  AddProgress 인자값으로 800
- 각 업적의 DisplayInfo를 호출하여 현재 상태를 출력.
- DisplaySummary를 호출하여 총 업적 및 달성된 업적 개수를 출력.
*/
using System;

namespace Assingment1_3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Achievement 객체를 3개 생성

            // 첫 번째 업적: "초급 도전자", "점수 100점 달성", 목표 100
            Achievement achievement1 = new("초급 도전자", "점수 100점 달성", 100);

            // 두 번째 업적: "중급 도전자", "점수 500점 달성", 목표 500
            Achievement achievement2 = new("중급 도전자", "점수 500점 달성", 500);

            // 세 번째 업적: "고급 도전자", "점수 1000점 달성", 목표 1000
            Achievement achievement3 = new("고급 도전자", "점수 1000점 달성", 1000);

            // 각 업적의 AddProgress 메서드를 호출하여 진행 상황을 업데이트:

            // // 첫 번째 업적에 AddProgress 인자값으로 100
            achievement1.AddProgress(100);

            // // 두 번째 업적에  AddProgress 인자값으로 600
            achievement2.AddProgress(600);

            // // 세 번째 업적에  AddProgress 인자값으로 800
            achievement3.AddProgress(800);

            // // 각 업적의 DisplayInfo를 호출하여 현재 상태를 출력.
            achievement1.DisplayInfo();

            Console.WriteLine();

            achievement2.DisplayInfo();

            Console.WriteLine();

            achievement3.DisplayInfo();

            Console.WriteLine();

            // DisplaySummary를 호출하여 총 업적 및 달성된 업적 개수를 출력.
            Achievement.DisplaySummary();
        }
    }

    // 편리한 사용을 위해 본인만의 myHelper 라는 클래스를 만들었다고 가정하겠습니다.
    public class MyHelper
    {
        // 정수 배열을 입력받아 해당 배열의 요소들 중에서 가장 작은 값을 반환하는 정적 메소드를 하나 작성하세요.
        public static int FindMinimum(int[] values)
        {
            int minValue = values[0];

            for (int i = 1; i < values.Length; ++i)
            {
                if (minValue < values[i])
                {
                    minValue = values[i];
                }
            }

            return minValue;
        }

        // 주어진 문자열에서 대문자의 개수를 세는 정적 메소드를 구현하세요.
        // 입력으로 주어지는 문자열은 비어있지 않다고 가정하겠습니다.
        // 정적 메서드를 사용하여 구현하여야 합니다.
        public static int CountOfUpper(string value)
        {
            // 문자열을 반복하여 대문자의 개수를 세고, 그 개수를 반환하여야 합니다.
            int count = 0;

            foreach (char c in value)
            {
                // char형의 내장 기능 중, IsUpper를 활용하면 대문자 여부를 확인 가능합니다.
                if (char.IsUpper(c) == true)
                {
                    ++count;
                }
            }

            return count;
        }
    }
}
