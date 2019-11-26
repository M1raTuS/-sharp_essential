using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();

            address.Index = 49035;
            address.Country = "Ukraine";
            address.City = "Dnepr";
            address.Street = "Kalinovaya";
            address.House = 79;
            address.Apartament = 59;

            Console.WriteLine(address.Index);
            Console.WriteLine(address.Country);
            Console.WriteLine(address.City);
            Console.WriteLine(address.Street);
            Console.WriteLine(address.House);
            Console.WriteLine(address.Apartament);

            Console.ReadLine();
        }
    }
}
