/* Универсальные шаблоны 

Используя Visual Studio, создайте проект по шаблону Console Application.  
Создайте расширяющий метод: public static T[] GetArray<T>(this MyList<T> list) 
Примените расширяющий метод к экземпляру типа MyList<T>, разработанному в Lesson 10.2. 
Выведите на экран значения элементов массива, который вернул расширяющий метод GetArray(). */

using System;

namespace Lesson_10._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива:");
            int u = Convert.ToInt32(Console.ReadLine()); 

            var list = new MyList<int>(u); 

            var t = new Random();
            for (int x = 0; x < u; x++)
            {
                list.Add(x, t.Next(100)); 
            }

            Console.WriteLine("Массив");
            int[] f = list.GetArray();   

            for (int i = 0; i < f.Length; i++)
            {
                Console.Write("{0} ", f[i]); 
            }

            Console.WriteLine();
            Console.WriteLine("Длинна массива: {0}", list.Length); 

            // Delay.
            Console.ReadKey();
        }
    }
}
