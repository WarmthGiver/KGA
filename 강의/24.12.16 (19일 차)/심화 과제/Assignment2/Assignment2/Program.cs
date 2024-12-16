/*
날짜: 24.12.16
이름: 이시온
*/
/*
### **심화 과제 ) 상속, 딕셔너리 활용**

Gun이라는 클래스와 Projectile이라는 클래스를 만들겠습니다.
그리고 Projectile 클래스를 상속받는 Bullet클래스와 Grenade 클래스를 만듭니다.
Grenade와 Bullet클래스에는 각각 필드로 int _damage 하나만 담아 두고, Gun 클래스에서 Bullet들을 담을 수 있는 List, Grenade들을 담을 수 있는 List, 총 두개의 리스트를 맴버변수로 가지게 합니다.

Gun의 생성자를 만들어서 해당 두 컨테이너들을 뉴할당 시켜줍니다.
마지막으로, Gun에 컨테이너를 하나 더 추가하겠습니다.
키값으로는 string을 받고, 내용으로는 방금 만들어진 List 컨테이너를 담는 Dictionary 필드를 만들어 주시기 바랍니다.

Gun의 생성자를 수정합니다.
방금 만들어진 딕셔너리를 뉴할당 하고, Bullet을 담은 List와 Grenade를 담은 List 둘을 각각 "Bullet", "Grenade" 이라는 키값으로 저장시켜주시기 바랍니다.
이를 위해 리팩토링을 진행해주시길 바랍니다

Gun에 메소드를 하나 더 추가하겠습니다.
"Bullet" 이라는 인자값을 넘겨주면 총알이 담긴 리스트를 반환 받고, "Grenade"라는 인자값을 넘겨주면 수류탄이 담긴 리스트를 반환 받는 메소드를 작성하여 주세요
*/

namespace Assignment2
{
    internal class Program
    {
        private static void Main(string[] args)
        {

        }

        // Gun이라는 클래스와,
        public sealed class Gun
        {
            // Gun 클래스에서 Bullet들을 담을 수 있는 List,
            public readonly List<Projectile> bullets;

            // Grenade들을 담을 수 있는 List, 총 두개의 리스트를 맴버변수로 가지게 합니다.
            public readonly List<Projectile> grenages;

            // 마지막으로, Gun에 컨테이너를 하나 더 추가하겠습니다.
            // 키값으로는 string을 받고, 내용으로는 방금 만들어진 List 컨테이너를 담는 Dictionary 필드를 만들어 주시기 바랍니다.
            public readonly Dictionary<string, List<Projectile>> projectiles;

            // Gun의 생성자를 만들어서,
            public Gun()
            {
                // 해당 두 컨테이너들을 뉴할당 시켜줍니다.
                bullets = new();

                grenages = new();

                // Gun의 생성자를 수정합니다.
                // 방금 만들어진 딕셔너리를 뉴할당 하고, Bullet을 담은 List와 Grenade를 담은 List 둘을 각각 "Bullet", "Grenade" 이라는 키값으로 저장시켜주시기 바랍니다.
                projectiles = new();

                projectiles["Bullet"] = bullets;

                projectiles["Grenade"] = grenages;
            }

            // Gun에 메소드를 하나 더 추가하겠습니다.
            public List<Projectile>? GetProjectiles(string type)
            {
                // "Bullet" 이라는 인자값을 넘겨주면 총알이 담긴 리스트를 반환 받고,
                // "Grenade"라는 인자값을 넘겨주면 수류탄이 담긴 리스트를 반환 받는 메소드를 작성하여 주세요.
                if (projectiles.ContainsKey(type) == true)
                {
                    return projectiles[type];
                }

                return null;
            }
        }

        // Projectile이라는 클래스를 만들겠습니다.
        public abstract class Projectile
        {
            private int damage;
        }

        // 그리고 Projectile 클래스를 상속받는 Bullet클래스와,
        public sealed class Bullet : Projectile
        {
            // Grenade와 Bullet클래스에는 각각 필드로 int _damage 하나만 담아 두고,
        }

        //  Grenade 클래스를 만듭니다.
        public sealed class Grenage : Projectile
        {

        }
    }
}