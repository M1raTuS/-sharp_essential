/* Статические и вложенные классы
 
Используя Visual Studio, создайте проект по шаблону Console Application.  
Требуется:  
Создать статический класс Calculator, с методами для выполнения основных арифметических операций. 
Написать программу, которая выводит на экран основные арифметические операции. */

using System;

namespace Lesson_6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator.Add(5, 2));
            Console.WriteLine(Calculator.Sub(5, 2));
            Console.WriteLine(Calculator.Mul(5, 2));
            Console.WriteLine(Calculator.Div(5, 2));
            Console.ReadKey();
        }
    }
}
