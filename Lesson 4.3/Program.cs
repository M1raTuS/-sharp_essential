/* Абстрактные классы и интерфейсы
 
Используя Visual Studio, создайте проект по шаблону Console Application.  
Требуется:  
Создайте 2 интерфейса IPlayable и IRecodable. 
В каждом из интерфейсов создайте по 3 метода void Play() / void Pause() / void Stop() и void Record() / void Pause() / void Stop() соответственно. 
Создайте производный класс Player от базовых интерфейсов IPlayable и IRecodable. Написать программу, которая выполняет проигрывание и запись. */

using System;

namespace Lesson_4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p = new Player();
            p.Play();
            (p as Interface.IPlayable).Pause();
            (p as Interface.IPlayable).Stop();

            p.Record();
            (p as Interface.IRecodable).Pause();
            (p as Interface.IRecodable).Stop();
            Console.ReadKey();
        }
    }
}
