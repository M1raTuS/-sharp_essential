using System;

namespace Lesson_5._4
{
    class Article
    {
        private double Price_UAH;

        public string productName { get; set; }
        public string magazineName { get; set; }
        public double price_UAH
        {
            get
            {
                return Price_UAH;
            }
            set
            {
                if (value >= 0)
                    Price_UAH = value;
                else
                    Console.WriteLine("Стоимость не может быть отрицательной");
            }
        }

        public Article(string product, string magazine, double price)
        {
            productName = product;
            magazineName = magazine;
            price_UAH = price;
        }

        public string Info() //Метод отображения значений полей класса
        {
            return string.Format("{0} из {1} стоимость : {2} грн.", productName, magazineName, Price_UAH);
        }
    }
}
