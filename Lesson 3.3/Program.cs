using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Price = 200;
            int speed = 50;
            int year = 2015;

            Vehicle v = new Vehicle(1,1,1,1,1);
            Plane p = new Plane(Price, speed, year)
            {
                Height = 50,
                count_passenger = 10
            };
            Ship s = new Ship(Price, speed, year)
            {
                Count_passenger = 6,
                Port = "Good"
            };
            Car c = new Car(Price, speed, year);

            Console.WriteLine(p.price + " " + p.speed +" "+p.year + " "+p.Height +" "+p.count_passenger);
            Console.WriteLine(s.price + " " + s.speed + " " + s.year + " " + s.Port + " " + s.Count_passenger);
            Console.WriteLine(s.price + " " + s.speed + " " + s.year);
            Console.ReadKey();

        }
    }
}
