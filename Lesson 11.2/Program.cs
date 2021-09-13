/* Универсальные шаблоны. Ограничения

Используя Visual Studio, создайте проект по шаблону Console Application.  
Создайте класс CarCollection<T>. Реализуйте в простейшем приближении возможность использования его экземпляра для создания парка машин. 
Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод добавления машин с названием машины и года ее выпуска, 
индексатор для получения значения элемента по указанному индексу и свойство только для чтения для получения общего количества элементов.  
Создайте метод удаления всех машин автопарка. */

using System;

namespace Lesson_11._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Наш парк машин:");
            var park = new CarCollection<string>(); 

            park.AddCar("Жигули", new DateTime(1985, 12, 5));
            park.AddCar("Тойота", new DateTime(2000, 4, 7));
            park.AddCar("Форд", new DateTime(2005, 5, 3));
            park.AddCar("Мерседес", new DateTime(2003, 11, 3));

            Console.WriteLine(park.ToString()); 

            Console.WriteLine("В парке находится: {0} машин", park.Lenght);

            Console.WriteLine("Введите номер интересующей вас машины:");
            string stroka = Console.ReadLine();

            if (string.IsNullOrEmpty(stroka)) 
                Console.WriteLine("Вы не ввели значение. Поиск не выполнен.");
            else
            {
                int nomer = Convert.ToInt32(stroka);
                Console.WriteLine(park[nomer - 1]);
            }

            Console.ReadKey();
        }
    }
}
