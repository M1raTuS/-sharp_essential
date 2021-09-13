/* Структуры и их разновидности 
 
Используя Visual Studio, создайте проект по шаблону Console Application. 
Создайте статический класс с методом void Print (string stroka, int color), который выводит на экран строку заданным цветом.  
Используя перечисление, создайте набор цветов, доступных пользователю. 
Ввод строки и выбор цвета предоставьте пользователю.  */

using System;

namespace Lesson_8._2
{
    static class Program
    {
        static void Print(string stroka, int color)
        {
            switch (color) //оператор многозначного выбора
            {
                case (int)Color.blue:
                    Console.ForegroundColor = ConsoleColor.Blue; //Установка цвета консоли
                    break;
                case (int)Color.green:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case (int)Color.red:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case (int)Color.black:
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case (int)Color.cyan:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case (int)Color.white:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                default:
                    Console.WriteLine("Введенная Вами строка будет выведена на экран цветом по умолчанию!");
                    break;
            }

            Console.WriteLine(stroka);
        }

        static void Main(string[] args)
        {
            string str = "Hello World";

            Print(str, (int)Color.white);

            Console.ReadKey();
        }
    }

    public enum Color
    {
        red,
        blue,
        black,
        cyan,
        white,
        green
    }
}
