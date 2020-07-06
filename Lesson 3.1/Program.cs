using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3._1
{
    class Program 
    {
        static void Main(string[] args)
        {
            ColorPrint p = new ColorPrint(ConsoleColor.Green);
            p.Print("Hi");

            Printer p1 = p;
            p1.Print("Hi");

            ColorPrint p2 = new ColorPrint(ConsoleColor.Yellow);
            p2.Print("Hi");

            Printer p4 = new Printer(ConsoleColor.Blue);
            p4.Print("Hi");



            Console.ReadKey();
        }
    }
}
