/* Потоки

Используя Visual Studio, создайте проект по шаблону Console Application.  
Создайте программу, которая будет выводить на экран цепочки падающих символов. 
Длина каждой цепочки задается случайно. Первый символ цепочки – белый, второй символ – светло-зеленый, 
остальные символы темно-зеленые. 
Во время падения цепочки, на каждом шаге, все символы меняют свое значение. 
Дойдя до конца, цепочка исчезает и сверху формируется новая цепочка. */

using System;
using System.Threading;

namespace Lesson_13._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 40);

            Matrix mat;

            for (int i = 0; i < 30; i++)
            {
                mat = new Matrix(i * 2);
                new Thread(mat.feel).Start();
            }

            Console.ReadKey();
        }
    }
}
