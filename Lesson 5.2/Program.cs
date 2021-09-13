/* Массивы и индексаторы
 
Используя Visual Studio, создайте проект по шаблону Console Application.  
Требуется:  
Создать массив размерностью N элементов, заполнить его произвольными целыми значениями.  
Вывести наибольшее значение массива, наименьшее значение массива, общую сумму элементов, среднее арифметическое всех элементов, вывести все нечетные значения. */

using System;

namespace Lesson_5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Array arr = new Array(12);

            arr.Max();
            Console.WriteLine("-----------");
            arr.Min();
            Console.WriteLine("-----------");
            arr.Sum();
            Console.WriteLine("-----------");
            arr.Middle();
            Console.WriteLine("-----------");
            arr.ne4();

            Console.ReadKey();
        }
    }
}
