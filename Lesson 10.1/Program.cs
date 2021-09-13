/* Универсальные шаблоны 
 
Используя Visual Studio, создайте проект по шаблону Console Application.  
Создайте класс MyClass<T>, содержащий статический фабричный метод – T FacrotyMethod(), 
который будет порождать экземпляры типа, указанного в качестве параметра типа (указателя места заполнения типом – Т). */

using System;

namespace Lesson_10._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = MyClass<int>.FacrotyMethod();

            Console.WriteLine(i.GetType().Name);

            Program p = MyClass<Program>.FacrotyMethod();

            Console.WriteLine(p.GetType().Name);

            double d = MyClass<double>.FacrotyMethod();

            Console.WriteLine(d.GetType().Name);

            Console.ReadKey();
        }
    }

    class MyClass<T> where T : new()
    {
        public static T FacrotyMethod()
        {
            return new T();
        }
    }
}
