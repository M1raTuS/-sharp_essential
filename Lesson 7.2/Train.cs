using System;

namespace Lesson_7._2
{
    class Train
    {
        private string name;
        private int number;
        private DateTime time;

        public Train(string name, int number, DateTime time)
        {
            this.name = name;
            this.number = number;
            this.time = time;
        }
        public string Name
        {
            get { return name; }
        }
        public int Number
        {
            get { return number; }
        }
        public DateTime Time
        {
            get { return time; }
        }
    }
}
