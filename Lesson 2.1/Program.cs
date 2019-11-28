using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string login = "log";
            string name = "Ivan";
            string surname = "Ivanov";
            int age = 18;

            User user = new User();
            User user2 = new User(login,name,surname,age);

            Console.WriteLine(user.date); 

            Console.ReadKey();
        }
    }
}
