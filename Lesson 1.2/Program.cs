using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle(21.5, 5);

            Console.WriteLine($"Area {rec.Area}; Perimetr {rec.Perimeter}");
            Console.ReadKey();
        }
    }
}
