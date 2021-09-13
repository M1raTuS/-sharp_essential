/* Универсальные шаблоны 

Используя Visual Studio, создайте проект по шаблону Console Application.  
Создайте класс MyDictionary<TKey,TValue>. 
Реализуйте в простейшем приближении возможность использования его экземпляра аналогично экземпляру класса Dictionary. 
Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод добавления пар элементов, 
индексатор для получения значения элемента по указанному индексу и свойство только для чтения для получения общего количества пар элементов */

using System;

namespace Lesson_10._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность словаря:");
            int n = Convert.ToInt32(Console.ReadLine());

            var dictionary = new MyDictionary<string, string>(n);

            for (int i = 0; i < n; i++)
            {
                dictionary.Add(i, "стол", "table");
            }

            Console.WriteLine(new string('-', 20));

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(dictionary[i]);
            }

            Console.WriteLine(new string('-', 20));

            Console.WriteLine(dictionary[1]);
            Console.WriteLine(dictionary.Length);

            // Delay.
            Console.ReadKey();
        }
    }
}
