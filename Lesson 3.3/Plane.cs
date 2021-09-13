using System;

namespace Lesson_3._3
{
    class Plane : Vehicle
    {
        int Count_passenger;
        public int count_passenger
        {
            get
            {
                return Count_passenger;
            }
            set
            {
                if (Count_passenger < 0)
                {
                    Console.WriteLine("Vvedite summy bol'we 0");
                }
                else
                {
                    Count_passenger = value;
                }
            }
        }

        public int Height { get; set; }
        public Plane(int X, int Y, int price, int speed, int year)
            : base(X, Y, price, speed, year)
        {

        }

        public Plane(int price, int speed, int year)
            : base(price, speed, year)
        {

        }
    }
}
