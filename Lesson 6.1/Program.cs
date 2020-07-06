using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator.Add(5, 2));
            Console.WriteLine(Calculator.Sub(5, 2));
            Console.WriteLine(Calculator.Mul(5, 2));
            Console.WriteLine(Calculator.Div(5, 2));
            Console.ReadKey();
            

        }
    }
}
