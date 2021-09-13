/* Наследование и полиморфизм
 
Используя Visual Studio, создайте проект по шаблону Console Application.  
Требуется:  
Создать класс, представляющий учебный класс ClassRoom.  
Создайте класс ученик Pupil.  В теле класса создайте методы void Study(), void Read(), void 
Write(), void Relax().  
Создайте 3 производных класса ExcelentPupil, GoodPupil, BadPupil  от класса базового класса Pupil и переопределите каждый из методов, в зависимости от успеваемости ученика.   
Конструктор класса ClassRoom принимает аргументы типа Pupil, класс должен состоять из 4 учеников. 
Предусмотрите возможность того, что пользователь может передать 2 или 3 аргумента.  
Выведите информацию о том, как все ученики экземпляра класса ClassRoom умеют учиться, читать, писать, отдыхать. */

using System;

namespace Lesson_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil p1 = new BadPupil();
            Pupil p2 = new GoodPupil();
            Pupil p3 = new ExcelentPupil();
            Pupil p4 = new Pupil();

            ClassRoom room1 = new ClassRoom(p1, p2, p3);

            room1.Study();
            Console.WriteLine(new string('*', 20));
            room1.Read();
            Console.WriteLine(new string('*', 20));
            room1.Write();
            Console.WriteLine(new string('*', 20));
            room1.Relax();
            Console.ReadKey();
        }
    }
}
