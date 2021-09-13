/* Наследование и полиморфизм
 
Используя Visual Studio, создайте проект по шаблону Console Application.  
Требуется:  
Создайте класс Printer.  
В теле класса создайте метод void Print(string value), который выводит на экран значение аргумента.  
Реализуйте возможность того, чтобы в случае наследования от данного класса других классов, и вызове соответствующего метода их экземпляра, строки, переданные в качестве аргументов методов, выводились разными цветами.  
Обязательно используйте приведение типов. */

using System;

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
