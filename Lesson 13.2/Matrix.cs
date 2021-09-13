using System;
using System.Threading;

namespace Lesson_13._2
{
    class Matrix
    {
        const string litters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        Random rand;
        static readonly object locker = new object();
        public int Column { get; set; }
        private char GetChar()
        {
            return litters.ToCharArray()[rand.Next(0, litters.Length - 1)];
        }
        public Matrix(int col)
        {
            Column = col;
            rand = new Random((int)DateTime.Now.Ticks);
        }
        public void feel()
        {
            int lenght;
            int count;
            while (true)
            {
                count = rand.Next(3, 30);
                lenght = 0;
                Thread.Sleep(rand.Next(20, 5000));
                for (int i = 0; i < 40; i++)
                {
                    lock (locker)
                    {
                        Console.CursorTop = 0;
                        Console.ForegroundColor = ConsoleColor.Black;
                        for (int j = 0; j < i; j++)
                        {
                            Console.CursorLeft = Column;
                            Console.WriteLine("█");
                        }
                        if (lenght < count)
                            lenght++;
                        else
                            if (lenght == count)
                            count = 0;

                        if (39 - i < lenght)
                            lenght--;
                        Console.CursorTop = i - lenght + 1;
                        Console.ForegroundColor = ConsoleColor.Green;
                        for (int j = 0; j < lenght - 2; j++)
                        {
                            Console.CursorLeft = Column;
                            Console.WriteLine(GetChar());
                        }
                        if (lenght >= 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.CursorLeft = Column;
                            Console.WriteLine(GetChar());
                        }
                        if (lenght >= 1)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.CursorLeft = Column;
                            Console.WriteLine(GetChar());
                        }
                        Thread.Sleep(20);
                    }
                }
            }
        }

    }
}
