/* Делегаты 
 
Используя Visual Studio, создайте проект по шаблону Console Application.  
Создайте анонимный метод, который принимает в качестве параметров три целочисленных аргумента и возвращает среднее арифметическое этих аргументов */

using System;

namespace Lesson_9._1
{
    class Program
    {
        private delegate int MyDelegate(int a, int b, int c);
        static void Main(string[] args)
        {
            MyDelegate myDelegate = (a, b, c) => (a + b + c);

            Console.WriteLine(myDelegate(5, 8, 2));
            Console.ReadKey();
        }
    }
}
