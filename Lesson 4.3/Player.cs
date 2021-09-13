using System;

namespace Lesson_4._3
{
    class Player : Interface.IPlayable, Interface.IRecodable
    {
        public void Play()
        {
            Console.WriteLine("Play melody");
        }

        public void Record()
        {
            Console.WriteLine("Start recording");
        }

        void Interface.IPlayable.Pause()
        {
            Console.WriteLine("Pause melody");
        }

        void Interface.IPlayable.Stop()
        {
            Console.WriteLine("Stop melody");
        }

        void Interface.IRecodable.Pause()
        {
            Console.WriteLine("Pause recording");
        }

        void Interface.IRecodable.Stop()
        {
            Console.WriteLine("Stop recording");
        }

    }
}
