/* Коллекции

Используя Visual Studio, создайте проект по шаблону Console Application.  
Создайте метод, который в качестве аргумента принимает массив целых чисел и возвращает коллекцию всех четных чисел массива. 
Для формирования коллекции используйте оператор yield. */

using System;
using System.Collections;

namespace Lesson_14._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,56,87,345,5,3454,87,66,44,99};
            Array.Sort(array);
            IEnumerable res = Massive(array);
            foreach (var item in res)
            {
                Console.Write("{0} ",item);
            }
            Console.ReadKey();
        }

        static IEnumerable Massive(int[] mas)
        {
            if (mas.Length != 0)
            {
                for (int i = 0; i < mas.Length; i++)
                {
                    if (mas[i] % 2 == 0)
                    {
                        yield return mas[i];
                    }
                }
            }
            else
            {
                yield break;
            }

        }
    }
}
