using System;

namespace Lesson_7._1
{
    public struct Notebook
    {
        readonly string model;
        readonly string production;
        readonly double price;

        public string Model
        {
            get { return model; }
        }
        public string Production
        {
            get { return production; }
        }

        public double Price
        {
            get { return price; }
        }


        public Notebook(string model, string production, double price)
        {
            this.model = model;
            this.production = production;
            this.price = price;
        }


        public void Show()
        {
            Console.WriteLine($"Model = {model}, production = {production}, price = {price}");
        }






    }
}
