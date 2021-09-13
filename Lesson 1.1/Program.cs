/*Классы и объекты

Используя Visual Studio, создайте проект по шаблону Console Application.
Требуется:  
Создать класс с именем Address.
В теле класса требуется создать поля: index, country, city, street, house, apartment.Для каждого поля, создать свойство с двумя методами доступа.  
Создать экземпляр класса Address.  
В поля экземпляра записать информацию о почтовом адресе.  Выведите на экран значения полей, описывающих адрес. */



using System;

namespace Lesson_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();

            address.Index = 49035;
            address.Country = "Ukraine";
            address.City = "Dnepr";
            address.Street = "Kalinovaya";
            address.House = 79;
            address.Apartament = 19;

            Console.WriteLine(address.Index);
            Console.WriteLine(address.Country);
            Console.WriteLine(address.City);
            Console.WriteLine(address.Street);
            Console.WriteLine(address.House);
            Console.WriteLine(address.Apartament);

            Console.ReadLine();
        }
    }
}
