/*
날짜: 24.12.20
이름: 이시온
*/

namespace Example1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //DelegateExample1();

            //AnnonymousMethodExample1();

            //CallbackDelegateExample1();

            //DelegateExample2();

            //ActionExample1();

            //FuncExample1();

            EventExample1();
        }

        #region 대리자(Delegate) 예제 1

        // 대리자(Delegate)
        // 메서드의 주소를 담는 변수.

        private delegate void ExampleDelegate();

        private static void DelegateExample1()
        {
            ExampleDelegate example = ExampleMethod1;

            // Invoke()
            // 대리자에 담긴 메서드를 실행.

            example.Invoke();
        }

        private static void ExampleMethod1()
        {
            Console.WriteLine("Invoke");
        }

        #endregion

        #region 익명 메서드(Anonymous Method) 예제

        private delegate int Calculator(int a, int b);

        private static void AnnonymousMethodExample1()
        {
            // 익명 메서드(Anonymous Method)
            // 이름이 없는 메서드.
            // 간단한 연산을 해야 할 때 사용하기 좋음.
            // 익명 메서드도 메서드이므로 대리자에 담을 수 있음.

            Calculator add = (a, b) => a + b;

            Console.WriteLine(add(1, 2));

            Calculator multiply = (a, b) => a * b;

            Console.WriteLine(multiply(1, 2));
        }

        #endregion

        #region 콜백(Callback) 메서드와 대리자 예제

        private delegate void CallbackDelegate();

        private static void CallbackDelegateExample1()
        {
            // 콜백(Callback)
            // 특정 작업이 끝난 후 실행하겠다는 의미.

            CallbackDelegate callback = () => Console.Write("Finished.");

            HeavyWork(callback);
        }

        private static void HeavyWork(CallbackDelegate callback)
        {
            Console.Write("Working");

            for (int i = 0; i < 3; ++i)
            {
                Console.Write('.');

                Thread.Sleep(1000);
            }

            callback.Invoke();
        }

        #endregion

        #region 대리자(Delegate) 예제 2

        private delegate bool CompareDelegate(int a, int b);

        private static void DelegateExample2()
        {
            int[] numbers = [5, 1, 4, 2, 3];

            Console.WriteLine(string.Join(", ", numbers));

            Sort(numbers, (a, b) => a > b);

            Console.WriteLine(string.Join(", ", numbers));
        }

        private static void Sort(int[] numbers, CompareDelegate compare)
        {
            for (int i = 0; i < numbers.Length; ++i)
            {
                for (int j = i; j < numbers.Length; ++j)
                {
                    if (compare(numbers[i], numbers[j]) == true)
                    {
                        int temp = numbers[i];

                        numbers[i] = numbers[j];

                        numbers[j] = temp;
                    }
                }
            }
        }

        #endregion

        #region Action 예제

        private static void ActionExample1()
        {
            // Action
            // 반환값이 void이고 매개 변수가 최대 16개인 메서드를 담을 수 있는 대리자.
            // 멀티캐스팅이 가능.

            Action action1 = Action1;

            Action action2 = Action2;

            action2 += Action2;

            Action<int> action3 = Action3;

            Action<int, float> action4 = Action4;

            action1.Invoke();

            action2.Invoke();

            action3.Invoke(0);

            action4.Invoke(0, 0f);
        }

        private static void Action1()
        {
            Console.WriteLine("Action 1");
        }

        private static void Action2()
        {
            Console.WriteLine("Action 2");
        }

        private static void Action3(int value)
        {
            Console.WriteLine("Action 3");
        }

        private static void Action4(int value1, float value2)
        {
            Console.WriteLine("Action 4");
        }

        #endregion

        #region Func 예제

        private static void FuncExample1()
        {
            // Func
            // 반환값이 있고 매개 변수가 최대 16개인 메서드를 담을 수 있는 대리자.
            // 멀티캐스팅이 가능하지만, 마지막으로 들어온 

            Func<int> func1 = Func1;

            Func<int> func2 = Func2;

            func2 += Func2;

            Func<int, int> func3 = Func3;

            Func<int, float, int> func4 = Func4;

            func1.Invoke();

            func2.Invoke();

            func3.Invoke(0);

            func4.Invoke(0, 0f);
        }

        private static int Func1()
        {
            Console.WriteLine("Func 1");

            return 0;
        }

        private static int Func2()
        {
            Console.WriteLine("Func 2");

            return 0;
        }

        private static int Func3(int value)
        {
            Console.WriteLine("Func 3");

            return 0;
        }

        private static int Func4(int value1, float value2)
        {
            Console.WriteLine("Func 4");

            return 0;
        }

        #endregion

        #region Event 예제

        private static void EventExample1()
        {
            Button button = new Button();

            button.OnClickEvent += () => Console.WriteLine("Click");

            //button?.Invoke();

            button.Click();
        }

        public sealed class Button
        {
            // event 키워드
            // 대리자의 Invoke() 메서드 사용을 차단하는 키워드.
            // 개발자의 의도를 벗어난 대리자 호출을 막아줌.

            public event Action? OnClickEvent = null;

            public void Click()
            {
                OnClickEvent?.Invoke();
            }
        }

        #endregion
    }
}