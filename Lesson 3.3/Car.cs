namespace Lesson_3._3
{
    class Car : Vehicle
    {
        public Car(int price, int speed, int year) : base(price, speed, year)
        {
        }

        public Car(int X, int Y, int price, int speed, int year) : base(X, Y, price, speed, year)
        {
        }
    }
}
