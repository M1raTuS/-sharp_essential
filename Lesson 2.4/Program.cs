using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2._4
{
    class Program
    {
        static void Main(string[] args)
        {


            Invoice inv = new Invoice(123, "VlAD", "Triolan") {Article = "USB", Quantity = 2};

            inv.CostCalc(true); //Вызов метода CostCalculation
            inv.CostCalc(false);
            Console.ReadKey();
        }
    }
}
