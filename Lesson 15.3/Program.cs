/* Обработка исключений 

Используя Visual Studio, создайте проект по шаблону Console Application.  
Требуется: Описать структуру с именем Price, содержащую следующие поля:  
•	название товара;  
•	название магазина, в котором продается товар;  
•	стоимость товара в гривнах.  
Написать программу, выполняющую следующие действия:  
•	ввод с клавиатуры данных в массив, состоящий из двух элементов типа Price (записи должны быть упорядочены в алфавитном порядке по названиям магазинов);  
•	вывод на экран информации о товарах, продающихся в магазине, название которого введено с клавиатуры (если такого магазина нет, вывести исключение). */

using System;

namespace Lesson_15._3
{
    class Program
    {
        static void Main()
        {
            PriceTable priceTable = new PriceTable();

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(priceTable[i]);
            }

            Console.WriteLine("Введите номер товара для поиска:");
            string product = Console.ReadLine();

            Console.WriteLine(priceTable[product]);

            Console.ReadKey();
        }
    }
}
