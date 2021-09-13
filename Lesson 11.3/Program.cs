/* Универсальные шаблоны. Ограничения

Используя Visual Studio, создайте проект по шаблону Console Application.  
Создайте класс Dictionary<TKey,TValue>. 
Реализуйте в простейшем приближении возможность использования его экземпляра 
аналогично экземпляру класса Dictionary из пространства имен System.Collections.Generic. 
Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод добавления пар элементов, 
индексатор для получения значения элемента по указанному индексу и 
свойство только для чтения для получения общего количества пар элементов.  */

using System;

namespace Lesson_11._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Словарь:");

            var dic = new Dictionary<string, string>();

            dic.Add("table", "стол");
            dic.Add("apple", "яблоко");
            dic.Add("sun", "солнце");
            dic.Add("pencil", "карандаш");
            dic.Add("cap", "чашка");
            dic.Add("tea", "чай");

            Console.WriteLine(dic.ToString());
            Console.WriteLine();
            Console.WriteLine("В словаре {0} записей", dic.Length);
            Console.WriteLine(new string('-', 30));

            Console.WriteLine("Введите номер записи в словаре:");
            string str = Console.ReadLine();
            if (string.IsNullOrEmpty(str))
                Console.WriteLine("Вы не ввели номер записи в словаре");
            else if (Convert.ToInt32(str) > dic.Length)
            {
                Console.WriteLine("Вы ввели неверный номер записи в словаре");
            }
            else
            {
                int nomer = Convert.ToInt32(str);
                Console.WriteLine(dic[nomer - 1]);
            }

            Console.WriteLine("Введите значение для поиска");
            string p = Console.ReadLine();
            Console.WriteLine(dic[p]);

            Console.ReadKey();
        }
    }
}
