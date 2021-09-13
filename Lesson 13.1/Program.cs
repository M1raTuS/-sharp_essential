/* Потоки

Используя Visual Studio, создайте проект по шаблону Console Application.  
Напишите программу, в которой метод будет вызываться рекурсивно.  
Каждый новый вызов метода выполняется в отдельном потоке. */

using System;
using System.Threading;

namespace Lesson_13._1
{
    class Program
    {
        static int d;

        static void Main(string[] args)
        {
            Thread thread = new Thread(Recursion)
            {
                Name = "Thread " + d + " Main"
            };
            thread.Start();

            Console.ReadKey();

        }

        static public void Recursion()
        {
            Console.WriteLine("{0}", Thread.CurrentThread.Name);
            Thread.Sleep(1000);
            Thread thread = new Thread(Recursion);
            d++;
            thread.Name = "Thread " + d + " Recurs";
            thread.Start();
        }
    }


}
