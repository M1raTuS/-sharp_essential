using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Figure(new Point(10,20,"1"), new Point(20, 30, "2"), new Point(30, 40, "3"), new Point(40, 50, "4"), new Point(50, 60, "5"));

            Console.WriteLine(figure.Type);

            figure.PerimeterCalculator();

            Console.ReadLine();
        }
    }
}
