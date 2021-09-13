/* Коллекции

Используя Visual Studio, создайте проект по шаблону Console Application.  
Создайте расширяющий метод: public static T[] GetArray<T>(this IEnumerable<T> list){…} 
Примените расширяющий метод к экземпляру типа MyList<T>, разработанному в домашнем задании 14.2. 
Выведите на экран значения элементов массива, который вернул расширяющий метод GetArray(). */

using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson_14._4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();

            for (int i = 0; i < 8; i++)
            {
                list.Add(i);
            }

            int[] arr = list.GetArray();

            foreach (int t in arr)
            {
                Console.Write("{0}  ", t);
            }

            Console.ReadKey();
        }
    }
    static class StaticClass
    {
        public static T[] GetArray<T>(this IEnumerable<T> list)
        {
            T[] array = new T[list.Count()];

            int i = 0;

            foreach (T item in list)
            {
                array[i] = item;
                i++;
            }

            return array;
        }
    }
}
