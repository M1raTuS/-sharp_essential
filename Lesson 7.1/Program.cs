using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7._1
{
    class Program
    {
        static void Main()

        {
            Notebook not = new Notebook("model", "product", 10.58);
            not.Show();
            Notebook not1 = new Notebook("Asus", "Phone", 1000);
            not1.Show();

            Console.ReadKey();

        }



    }
}
