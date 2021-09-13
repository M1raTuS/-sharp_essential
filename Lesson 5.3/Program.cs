/* Массивы и индексаторы
 
Используя Visual Studio, создайте проект по шаблону Console Application.  
Требуется:  
Создать класс MyMatrix, обеспечивающий представление матрицы произвольного размера с возможностью изменения числа строк и столбцов.  
Написать программу, которая выводит на экран матрицу и производные от нее матрицы разных порядков. */

using System;

namespace Lesson_5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMatrix m = new MyMatrix(5, 5);
            m.Show();
            Console.WriteLine("");
            m.ShowPartial(1, 1, 4, 3);
            Console.WriteLine("");
            m.Change(2, 2);
            Console.WriteLine("");
            m.Change(1, 3, 57);

            m.Show();

            Console.ReadKey();
        }
    }
}
