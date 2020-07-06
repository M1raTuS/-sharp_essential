using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMatrix m = new MyMatrix(5, 5);
            m.Show();
            Console.WriteLine("");
            m.ShowPartial(1,1,4,3);
            m.Change(2,2);

            m.Show();

            Console.ReadKey();
        }
    }
}
