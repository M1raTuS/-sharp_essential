using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7._2
{
    class MyClass
    {
        public static void AddingTrain(Train[] train)
        {
            for (int i = 0; i < train.Length; i++)
            {
                Console.Write("Введите пункт назначения поезда:");
                string punkt = Console.ReadLine(); //Считывание значения с клавиатуры
                punkt = string.IsNullOrEmpty(punkt) ? "Не указан пункт назначения" : punkt; //Запись в поле с помощью тернарного оператора

                Console.Write("Введите номер поезда:");
                string d = Console.ReadLine();
                int nomer = string.IsNullOrEmpty(d) ? 0 : Convert.ToInt32(d);

                Console.Write("Введите дату отправления:");
                d = Console.ReadLine();
                DateTime date = string.IsNullOrEmpty(d) ? DateTime.Now : DateTime.Parse(d);

                train[i] = new Train(punkt, nomer, date); //Создание нового екземпляра класса Train и присвоение ссылки на него в массив train
            }
        }
        public static void Show(Train[] train)
        {
            for (int i = 0; i < train.Length; i++)
            {
                Console.WriteLine("Номер поезда: {0} Пункт назначения: {1} Дата и время отправления: {2} ", train[i].Number,
                                  train[i].Name, train[i].Time);

            }
        }
        public static void Search(Train[] train, int poisk) //Статический метод поиска указаной записи в массиве по ключу (номер поезда)
        {
            bool ok = false; //Создание переменной логического типа
            for (int i = 0; i < train.Length; i++) //Проход по всем элементам массива
            {
                if (train[i].Number == poisk) //Проверка, эсть запись в массиве с таким номером поезда или нет
                {
                    Console.WriteLine("Номер поезда: {0} Пункт назначения: {1} Дата и время отправления: {2} ",
                                      train[i].Number, train[i].Name, train[i].Time);
                    ok = true; //При успешном нахождении записи, ставим "флаг"

                }
            }
            if (!ok) //Если такой записи нету "флаг" останется false и выполнится следуйщий код
                Console.WriteLine("Поезд не найден!");
        }
        public static void Sort(Train[] trains) //Статический метод сортировки массива по номерам поездов
        {
            for (int i = 0; i < trains.Length; i++)
            {
                for (int q = 0; q < trains.Length; q++)
                {
                    if (trains[i].Number <= trains[q].Number)
                    {
                        Train g = trains[i];
                        trains[i] = trains[q];
                        trains[q] = g;
                    }
                }
            }
        }

    }
}
