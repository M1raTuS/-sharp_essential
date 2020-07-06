using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var train = new Train[2];

            MyClass.AddingTrain(train);
            Console.WriteLine("Вы ввели такую информацию о поездах:");
            MyClass.Sort(train);
            MyClass.Show(train);
            Console.WriteLine("Введите номер поезда:");
            int poisk = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(new string('-', 50));
            MyClass.Search(train, poisk);

            Console.ReadKey();
        }
    }
}
