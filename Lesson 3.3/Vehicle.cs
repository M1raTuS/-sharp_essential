namespace Lesson_3._3
{
    class Vehicle
    {
        int X, Y, Price, Speed, Year;

        public Vehicle(int X, int Y, int price, int speed, int year)
        {
            this.X = X;
            this.Y = Y;
            this.Price = price;
            this.Speed = speed;
            this.Year = year;
        }

        public Vehicle(int price, int speed, int year)
            : this(0, 0, price, speed, year)
        {

        }

        public int x { get => X; }
        public int y { get => Y; }
        public int price { get => Price; }
        public int speed { get => Speed; }
        public int year { get => Year; }

    }
}
