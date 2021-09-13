/* Перегрузка операторов 

Используя Visual Studio, создайте проект по шаблону Console Application.  
Создайте структуру описывающую точку в трехмерной системе координат. 
Организуйте возможность сложения двух точек, через использование перегрузки оператора +. */

using System;

namespace Lesson_16._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(1, 1, 1);
            Point b = new Point(2, 2, 2);

            Point c = a + b;

            Console.WriteLine("Координаты точки с равны " + c.X + " " + c.Y + " " + c.Z);

            Console.ReadKey();
        }
    }
}
