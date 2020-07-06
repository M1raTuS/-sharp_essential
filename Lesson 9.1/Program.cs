using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_9._1
{
    class Program
    {
        private delegate int MyDelegate(int a, int b, int c); 
        static void Main(string[] args)
        {
            MyDelegate myDelegate = (a, b, c) => (a + b + c);

            Console.WriteLine(myDelegate(5, 8, 2));
            Console.ReadKey();
        }
    }
}
