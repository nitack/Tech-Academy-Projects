using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1. Create a const variable

//2. Create a variable using the keyword "var".

//3. Chain two constructors together.

namespace drill162
{
    class Program
    {
        static void Main(string[] args)
        {
            const string principalName = "Mr. Waller";

            Console.WriteLine("Hello, what is your name?");
            var name = Console.ReadLine();
            Student student = new Student(name);
            Console.WriteLine("Hello, {0}.  You will be attending PS {1}.  The principal is {2}.", student.Name, student.School, principalName);
            Console.ReadLine();


        }
    }
}
