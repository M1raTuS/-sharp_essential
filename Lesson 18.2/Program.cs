/* Пространства имен. Директивы препроцессора

Используя пример Lesson 15.3, 
реализуйте возможность подключения вашего пространства имен и работы с MyDictionary<TKey,TValue> 
аналогично экземпляру класса Dictionary<TKey,TValue> */

using System;

using Dictionary;

namespace Lesson_18._2
{
    class Program
    {
        static void Main()
        {
            MyDictionary<char, string> dictionary = new MyDictionary<char, string>();
            dictionary.Add('a', "Эй");
            dictionary.Add('b', "Би");
            dictionary.Add('c', "Си");
            dictionary.Add('d', "Ди");

            Console.WriteLine(dictionary['b']);

            foreach (string pair in dictionary)
            {
                Console.WriteLine(pair);
            }

            Console.ReadKey();
        }
    }
}
