/* Статические и вложенные классы
 
Используя Visual Studio, создайте проект по шаблону Console Application.  
Требуется: создать расширяющий метод для целочисленного массива, который сортирует элементы массива по возрастанию. */

using System;

namespace Lesson_6._4
{
    class Program
    {

        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] mas = new int[15];
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] += rand.Next(0, 100);
            }

            mas.SortUp();

            foreach (var q in mas)
            {
                Console.WriteLine(q);
            }

            Console.ReadKey();
        }
    }
    static class MassiveExtension
    {
        public static void SortUp(this int[] mass)
        {
            int temp = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                for (int j = 0; j < mass.Length - 1; j++)
                {
                    if (mass[j] > mass[j + 1])
                    {
                        temp = mass[j + 1];
                        mass[j + 1] = mass[j];
                        mass[j] = temp;
                    }
                }
            }
        }
    }
}
