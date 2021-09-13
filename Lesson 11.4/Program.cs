/* Универсальные шаблоны. Ограничения

Используя Visual Studio, создайте проект по шаблону Console Application.  
Создайте класс ArrayList. 
Реализуйте в простейшем приближении возможность использования его экземпляра 
аналогично экземпляру класса ArrayList из пространства имен System.Collections. */

using System;

namespace Lesson_11._4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArrayList m = new MyArrayList();

            m.Add(5);
            m.Add("Hello");
            m.Add('d');
            m.Add(5.78);

            Console.WriteLine("Массив:");
            Console.WriteLine(m.ToString());

            Console.ReadKey();
        }
    }
}
