/* Потоки

Используя Visual Studio, создайте проект по шаблону Console Application.  
Расширьте Lesson 13.2, так, чтобы в одном столбце одновременно могло быть две цепочки символов. */

using System;
using System.Threading;

namespace Lesson_13._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 40);

            Matrix mat;

            for (int i = 0; i < 30; i++)
            {
                mat = new Matrix(i * 3,true);
                new Thread(mat.feel).Start();
            }

            Console.ReadKey();
        }
    }
}
