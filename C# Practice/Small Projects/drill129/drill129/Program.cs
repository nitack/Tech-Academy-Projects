using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Overload the "==" operator so it checks if two Employee objects are equal by comparing their Id property.

namespace drill129
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Employee employee = new Employee()
            {
                FirstName = "Sample",
                LastName = "Student",
                Id = 001,
            };
            Employee employee2 = new Employee()
            {
                FirstName = "Some",
                LastName = "Student",
                Id = 002,
            };
            Console.WriteLine("Do the two employees have the same ID?");
            Console.WriteLine(employee == employee2);


            Console.ReadLine();
        }
    }
}
