/*Классы и объекты
 
Используя Visual Studio, создайте проект по шаблону Console Application.  
Требуется:  
Создать класс Converter. 
В теле класса создать пользовательский конструктор, который принимает три вещественных аргумента, 
и инициализирует поля соответствующие курсу 3-х основных валют, по отношению к гривне – public Converter(double usd, double eur, double rub).  
Написать программу, которая будет выполнять конвертацию из гривны в одну из указанных валют, также программа должна производить конвертацию из указанных валют в гривну. */

using System;

namespace Lesson_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double uah = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();


            Converter conv = new Converter(24.1, 28.5, 0.3);

            conv.UsdToUah(uah);
            Console.WriteLine();

            conv.EurToUah(uah);
            Console.WriteLine();

            conv.RubToUah(uah);
            Console.WriteLine();

            conv.UahToUsd(uah);
            Console.WriteLine();

            conv.UahToEur(uah);
            Console.WriteLine();

            conv.UahToRub(uah);
            Console.WriteLine();


            Console.ReadKey();
        }
    }
}
