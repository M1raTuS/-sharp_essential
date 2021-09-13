/*Классы и объекты
 
Используя Visual Studio, создайте проект по шаблону Console Application.  
Требуется:  
Создать классы Point и Figure.  
Класс Point должен содержать два целочисленных поля и одно строковое поле. 
Создать три свойства с одним методом доступа get.  
Создать пользовательский конструктор, в теле которого проинициализируйте поля значениями аргументов. 
Класс Figure должен содержать конструкторы, которые принимают от 3-х до 5-ти аргументов типа Point. 
Создать два метода: double LengthSide(Point A, Point B), который рассчитывает длину стороны многоугольника; void PerimeterCalculator(), который рассчитывает периметр многоугольника. */

using System;

namespace Lesson_1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Figure(new Point(10, 20, "1"), new Point(20, 30, "2"), new Point(30, 40, "3"), new Point(40, 50, "4"), new Point(50, 60, "5"));

            Console.WriteLine(figure.Type);

            figure.PerimeterCalculator();

            Console.ReadLine();
        }
    }
}
