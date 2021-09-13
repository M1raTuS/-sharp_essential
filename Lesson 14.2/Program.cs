/* Коллекции

Используя Visual Studio, создайте проект по шаблону Console Application.  
Создайте коллекцию MyList<T>. 
Реализуйте в простейшем приближении возможность использования ее экземпляра аналогично экземпляру класса List<T>. 
Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод добавления элемента, 
индексатор для получения значения элемента по указанному индексу и свойство только для чтения для получения общего количества элементов. 
Реализуйте возможность перебора элементов коллекции в цикле foreach. */

using System;

namespace Lesson_14._2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();
            for (int i = 0; i < 20; i++)
            {
                list.Add(i);
            }

            Console.WriteLine(list.Count);
            Console.WriteLine();
            foreach (var item in list)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine("\n");
            Console.WriteLine(list[6]);
            Console.ReadKey();
        }
    }
}
