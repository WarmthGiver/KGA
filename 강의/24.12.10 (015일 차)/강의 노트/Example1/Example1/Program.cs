namespace Example1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //FunctionOverloadingExample();

            //ConstructorExample();

            //DestructorExample();

            DefaultParameterExample();
        }

        #region 함수 오버로딩(Fuction Overloading) 예제
       
        public static void FunctionOverloadingExample()
        {
            OverLoadedFuction();

            OverLoadedFuction(0);
        }

        // 함수 오버로딩(Function Overloading)
        // 
        public static void OverLoadedFuction()
        {
            Console.WriteLine($"OverLoadedFunction()");
        }

        public static void OverLoadedFuction(int value)
        {
            Console.WriteLine($"OverLoadedFunction(int)");
        }

        #endregion

        #region 생성자(Constructor) 예제

        public sealed class ConstructorExampleClass
        {
            public int value;

            // 생성자(Constructor)
            // 

            // 기본 생성자(Default Constructor)
            // 
            public ConstructorExampleClass()
            {
                value = 0;

                Console.WriteLine("Constructor()");
            }

            // 생성자 오버로딩(Constructor Overloading)
            // 
            public ConstructorExampleClass(int value)
            {
                // 멤버 변수와 매개 변수의 이름이 같을 경우 멤버 변수 앞에 this 키워드를 붙여 구분이 가능.
                this.value = value;

                Console.WriteLine($"Constructor(int)");
            }
        }

        public static void ConstructorExample()
        {
            ConstructorExampleClass class1 = new ConstructorExampleClass();

            ConstructorExampleClass class2 = new ConstructorExampleClass(1);

            Console.WriteLine($"class1.value: {class1.value}");

            Console.WriteLine($"class2.value: {class2.value}");
        }

        #endregion

        #region 소멸자(Destructor) 예제

        public sealed class DestructorExampleClass
        {
            public DestructorExampleClass()
            {
                Console.WriteLine("생성");
            }

            // 소멸자(Destructor)
            // 
            ~DestructorExampleClass()
            {
                Console.WriteLine("소멸");
            }
        }

        public static void DestructorExample()
        {
            CreateNewClass();

            GC.Collect();
        }

        public static void CreateNewClass()
        {
            DestructorExampleClass class1 = new DestructorExampleClass();
        }

        #endregion

        #region 기본 매개변수(Default Parameter) 예제

        // 기본 매개변수(Default Parameter)
        // 매개변수에 기본값을 지정하여 함수를 호출할 때 매개변수를 넣지 않으면 기본값을 알아서 넣어줌.
        public static void DefaultParameterFunction(int value = 0)
        {
            Console.WriteLine($"value: {value}");
        }

        public sealed class DefaultParameterExampleClass
        {
            public int value;

            // 생성자의 매개변수도 기본 매개변수를 지정해줄 수 있음.
            public DefaultParameterExampleClass(int value = 1)
            {
                this.value = value;
            }

            // 기본 매개변수로 인한 함수 오버로딩 혼동
            // 오버로드된 함수가 있을 경우 우선적으로 호출.
            public DefaultParameterExampleClass()
            {
                value = 0;
            }
        }

        public static void DefaultParameterExample()
        {
            DefaultParameterFunction();

            DefaultParameterFunction(1);

            DefaultParameterExampleClass class1 = new DefaultParameterExampleClass();

            DefaultParameterExampleClass class2 = new DefaultParameterExampleClass();

            Console.WriteLine($"class1.value: {class1.value}");

            Console.WriteLine($"class2.value: {class2.value}");
        }

        #endregion
    }
}