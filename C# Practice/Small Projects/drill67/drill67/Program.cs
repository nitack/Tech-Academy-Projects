using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drill67
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            int rate1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Hours Worked per week?");
            int hours1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            int rate2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Hours Worked per week?");
            int hours2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Weekly salary of Person 1");
            int salary1 = rate1 * hours1;
            Console.WriteLine(salary1);
            Console.WriteLine("Weekly salary of Person 2");
            int salary2 = rate2 * hours2;
            Console.WriteLine(salary2);
            Console.WriteLine("Does Person 1 make more money than Person2?");
            bool compare = salary1 > salary2;
            Console.WriteLine(compare);
            Console.ReadLine();

        }
    }
}
