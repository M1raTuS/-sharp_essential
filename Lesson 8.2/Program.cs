using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    Console.ForegroundColor = ConsoleColor.Black; //Установка цвета консоли
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
