using System;

namespace Lesson_2._4
{
    class Invoice
    {

        int account;
        string customer, provider;
        string article;
        int quantity;

        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }

        public int Quantity { get => quantity; set => quantity = value; }
        public string Article { get => article; set => article = value; }

        public void CostCalc(bool nds)
        {
            double cost;
            switch (Article)   //Оператор многозначного выбора
            {
                case "laptop":
                    cost = 5400;
                    break;
                case "SD-cadr":
                    cost = 30;
                    break;
                case "USB":
                    cost = 12;
                    break;
                default:
                    Console.WriteLine("Нет ифформации о таком товаре");
                    return;
            }
            if (nds)
            {
                cost = cost * 7 / 6;
            }
            Console.WriteLine("Cуммa оплаты: {0}$", cost * Quantity);
        }
    }

}
