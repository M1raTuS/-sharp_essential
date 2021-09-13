/* Наследование и полиморфизм
 
Используя Visual Studio, создайте проект по шаблону Console Application.  
Требуется:  
Создать класс Vehicle.  
В теле класса создайте поля:  координаты и параметры средств передвижения (цена, скорость, год выпуска).  
Создайте 3 производных класса Plane, Саг и Ship.  
Для класса Plane должна быть определена высота и количество пассажиров.  
Для класса Ship — количество пассажиров и порт приписки.  
Написать программу, которая выводит на экран информацию о каждом средстве передвижения. */

using System;

namespace Lesson_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Price = 200;
            int speed = 50;
            int year = 2015;

            Vehicle v = new Vehicle(1, 1, 1, 1, 1);
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

            Console.WriteLine(v.price + " " + v.speed + " " + v.year);
            Console.WriteLine(p.price + " " + p.speed + " " + p.year + " " + p.Height + " " + p.count_passenger);
            Console.WriteLine(s.price + " " + s.speed + " " + s.year + " " + s.Port + " " + s.Count_passenger);
            Console.WriteLine(c.price + " " + c.speed + " " + c.year);
            Console.ReadKey();

        }
    }
}
