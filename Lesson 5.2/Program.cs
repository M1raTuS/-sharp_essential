using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Array arr = new Array(12);

            arr.Max();
            Console.WriteLine("-----------");
            arr.Min();
            Console.WriteLine("-----------");
            arr.Sum();
            Console.WriteLine("-----------");
            arr.Middle();
            Console.WriteLine("-----------");
            arr.ne4();

            Console.ReadKey();
        }
    }
}
