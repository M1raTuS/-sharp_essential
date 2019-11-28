using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double uah = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            

            Converter conv = new Converter(24.1,28.5,0.3);

            conv.UsdToUah(uah);
            Console.WriteLine();

            conv.EurToUah(uah);
            Console.WriteLine();

            conv.RubToUah(uah);
            Console.WriteLine();

            conv.UahToUsd(uah);
            Console.WriteLine();

            conv.UahToEur(uah);
            Console.WriteLine();

            conv.UahToRub(uah);
            Console.WriteLine();

           
            Console.ReadKey();
        }
    }
}
