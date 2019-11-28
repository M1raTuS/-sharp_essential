using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Smith", "Petr");
            employee.Post = "manager"; 
            employee.Experience = 1; 

            Console.WriteLine(employee.Surname + " " + employee.Name + " " + employee.Post.ToUpper());
            employee.ShowSalary();

            Console.ReadKey();
        }
    }
}
