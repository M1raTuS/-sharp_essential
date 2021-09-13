/* Универсальные шаблоны 

Используя Visual Studio, создайте проект по шаблону Console Application.  
Создайте класс MyList<T>. Реализуйте в простейшем приближении возможность использования его экземпляра аналогично экземпляру класса List<T>. 
Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод добавления элемента, 
индексатор для получения значения элемента по указанному индексу и свойство только для чтения для получения общего количества элементов.   */

using System;

namespace Lesson_10._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива:");
            string str = Console.ReadLine();
            int u = string.IsNullOrEmpty(str) ? 0 : Convert.ToInt32(str);

            var list = new MyList<int>();

            var t = new Random();
            for (int x = 0; x < u; x++)
            {
                list.Add(t.Next(100));
            }

            Console.WriteLine("Массив элементов:");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(new string('-', 30));
            try
            {
                Console.WriteLine("Введите значение для поиска:");
                if (list.Contains(Convert.ToInt32(Console.ReadLine())))
                {
                    Console.WriteLine("Введенное значение содержится в массиве");
                }
                else
                {
                    Console.WriteLine("Значение не найдено!");
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Вы ввели неправильные данные");
            }
           
            Console.WriteLine();
            if (list.Count > 0)
            {
                Console.WriteLine(list[0].ToString());
            }

            Console.ReadKey();

        }

    }
}