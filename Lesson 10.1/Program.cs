using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
