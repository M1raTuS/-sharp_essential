namespace Lesson_3._3
{
    class Ship : Vehicle

    {
        public Ship(int X, int Y, int price, int speed, int year)
            : base(X, Y, price, speed, year)
        {

        }
        public Ship(int price, int speed, int year)
            : base(price, speed, year)
        {

        }
        int count_passenger;
        string port;

        public int Count_passenger { get => count_passenger; set => count_passenger = value; }
        public string Port { get => port; set => port = value; }
    }
}
