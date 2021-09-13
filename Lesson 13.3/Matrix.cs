using System;
using System.Threading;

namespace Lesson_13._3
{
    class Matrix
    {
        const string litters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        Random rand;

        static readonly object locker = new object();

        public int Column { get; set; }

        public bool NeedSecond { get; set; }

        private char GetChar()
        {
            return litters.ToCharArray()[rand.Next(0, litters.Length - 1)];
        }

        public Matrix(int col, bool needSecond)
        {
            Column = col;
            rand = new Random((int)DateTime.Now.Ticks);
            NeedSecond = needSecond;
        }

        public void feel()
        {
            int lenght;
            int count;
            while (true)
            {
                count = rand.Next(3, 12);
                lenght = 0;
                Thread.Sleep(rand.Next(20, 5000));
                for (int i = 0; i < 40; i++)
                {
                    lock (locker)
                    {
                        Console.CursorTop = i - lenght;
                        Console.ForegroundColor = ConsoleColor.Black;
                        for (int j = i - lenght - 1; j < i; j++)
                        {
                            Console.CursorLeft = Column;
                            Console.WriteLine("█");
                        }
                        if (lenght < count)
                            lenght++;
                        else
                            if (lenght == count)
                            count = 0;

                        if (NeedSecond && i < 20 && i > lenght + 2 && (rand.Next(1, 5) == 3))
                        {
                            new Thread((new Matrix(Column, false)).feel).Start(); 
                            NeedSecond = false;
                        }

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
