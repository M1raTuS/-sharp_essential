using System;

namespace Lesson_2._2
{
    class Converter
    {
        double usd, eur, rub;

        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }

        internal double UsdToUah(double uah)
        {
            Console.WriteLine("UahToUsd");
            Console.WriteLine(uah * usd + " usd");
            return uah * usd;
        }
        public double EurToUah(double uah)
        {
            Console.WriteLine("UahToEur");
            Console.WriteLine(uah * eur + " eur");
            return uah * eur;
        }

        public double RubToUah(double uah)
        {
            Console.WriteLine("UahToRub");
            Console.WriteLine(uah * rub + " rub");
            return uah * rub;
        }
        public double UahToUsd(double uah)
        {
            Console.WriteLine("UsdToUah");
            Console.WriteLine(uah / usd + " uah");
            return uah / usd;
        }
        public double UahToEur(double uah)
        {
            Console.WriteLine("EurToUah");
            Console.WriteLine(uah / eur + " uah");
            return uah / eur;
        }

        public double UahToRub(double uah)
        {
            Console.WriteLine("RubToUah");
            Console.WriteLine(uah / rub + " uah");
            return uah / rub;
        }
    }
}
