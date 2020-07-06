using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store(5);

            store.AddArticle(new Article("Apple","ATB",54.99),0);
            store.AddArticle(new Article("Mango", "Varus", 105.45), 1);
            store.AddArticle(new Article("Banana", "Metro", 10.15), 2);
            store.AddArticle(new Article("Lemon", "ATB", 0.99), 3);

            store.Show();

            Console.WriteLine("");

            Console.WriteLine(store["Mango"]); 
            Console.WriteLine(new string('-', 30));

            Console.WriteLine(store["Dog"]);
            Console.WriteLine(new string('-', 30));

            Console.WriteLine(store[2]);
            Console.WriteLine(new string('-', 30));


            Console.ReadKey();

        }
    }
}
