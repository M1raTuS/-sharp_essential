/* Массивы и индексаторы
 
Используя Visual Studio, создайте проект по шаблону Console Application.  
Требуется:  
Создать класс Article, содержащий следующие закрытые поля: 
•	название товара; 
•	название магазина, в котором продается товар; 
•	стоимость товара в гривнах. 
Создать класс Store, содержащий закрытый массив элементов типа Article.  
Обеспечить следующие возможности: 
•	вывод информации о товаре по номеру с помощью индекса; 
•	вывод на экран информации о товаре, название которого введено с клавиатуры, если таких товаров нет, выдать соответствующее сообщение; 
Написать программу, вывода на экран информацию о товаре. */

using System;

namespace Lesson_5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store(5);

            store.AddArticle(new Article("Apple", "ATB", 54.99), 0);
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
