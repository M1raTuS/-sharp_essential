/* Коллекции

Используя Visual Studio, создайте проект по шаблону Console Application.  
Создайте коллекцию MyDictionary<TKey,TValue>. 	
Реализуйте в простейшем приближении возможность использования ее экземпляра аналогично экземпляру класса Dictionary<TKey,TValue>. 
Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод добавления элемента, 
индексатор для получения значения элемента по указанному индексу и свойство только для чтения для получения общего количества элементов. 
Реализуйте возможность перебора элементов коллекции в цикле foreach. */

using System;

namespace Lesson_14._3
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new MyDictionary<string, string>(5);

            dictionary.Add(0, "стол", "table");
            dictionary.Add(1, "яблоко", "aplle");
            dictionary.Add(2, "карандаш", "pencil");
            dictionary.Add(3, "солнце", "sun");
            dictionary.Add(4, "блокнот", "notepad");

            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new string('-', 20));
            Console.WriteLine("Вторая запись в словаре:");
            Console.WriteLine(dictionary[1]);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine("Размер словаря:");
            Console.WriteLine(dictionary.Length + " слов");
            Console.WriteLine(new string('-', 50));

            Console.ReadKey();
        }
    }
}
