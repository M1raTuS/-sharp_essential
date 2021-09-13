/* Пространства имен. Директивы препроцессора

Создайте класс с методом помеченным модификатором доступа public. 
Докажите, что к данному методу можно обратиться не только из текущей сборки, но и из производного класса внешней сборки */

extern alias T2; 

namespace Lesson_18._3
{
    class Program
    {
        static void Main()
        {
            T2.Lesson_18._3._1.MyClass my = new T2.Lesson_18._3._1.MyClass(); 

            my.Method();

            System.Console.ReadKey();
        }
    }
}
