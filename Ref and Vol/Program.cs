namespace Ref_and_Vol
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            User p = new User();
            User q = new User();
            p.Name = "Ku";
            q.Name = "Ku";
            UserRename(p);
            UserRename(q);
            Console.WriteLine(p.Name);
            if (p.Name == q.Name) Console.WriteLine("+");//сравниваем чисто по имени
            else Console.WriteLine("-");

            if (p.Equals(q)) Console.WriteLine("YES");//сравниваем целиком объекты
            else Console.WriteLine("NO");

            Fox a = new Fox();
            a.Name = "Ja";
            Fox b = a; //в б записывается то же что было в а, тк это не ссылочный тип
            if (a.Equals(b)) Console.WriteLine("DAAAAAAAA!!!!"); //ну и сравниваем
            else Console.WriteLine("NEEEEEEEET!!!");
            int c = 0;
            int d = 0;
            c = Increment(c);
            Console.WriteLine(c);
            Increment2(ref d);//передаём ссылку
            Console.WriteLine(d);

            bool correct = ValidateLogin("", out string error);
            if (correct) Console.WriteLine("Login is correct");
            else
            {
                Console.WriteLine("Login is incorrect");
                Console.WriteLine(error);
            }


           bool success = int.TryParse("123", out int result);
            if (success) Console.WriteLine(result + 1);
            else Console.WriteLine("Can not convert!");
            success = int.TryParse("!", out result);
            if (success) Console.WriteLine(result + 1);
            else Console.WriteLine("Can not convert!");
        }




        public class User
        {
            public string Name { get; set; }
            public override bool Equals(object obj) //сравнение по имени с элементом класса юсер
            {
                if (obj is User Other) //если чел в сковочках это элемент класса юсер то он азерюзер
                {
                    return Name.Equals(Other.Name); //и возвращаем результат сравнения элемента с точкой и чела в скобках по имени
                }
                return false;
            }
        }


        public struct Fox() //Структура фокс не ссылочная
        {
            public string Name { get; set; }
        }

        static void UserRename(User a) //добавляет ! к элементу класса юсер
        {
            a.Name += " !";
        }


        public static int Increment(int t)//Мой инкремент
        {
            t++;
            return t;
        }
        public static void Increment2(ref int t)//Инкремент автора по ссылке
        {
            t++;
        }


    public static bool ValidateLogin(string login, out string error) //проверка на непустоту логина. Принимает логин, возвращает да или нет и строку
        {
            if (login.Length == 0)
            {
                error = "Login is empty";
                return false;
            }
            error = null;
            return true;
        }
    }
}