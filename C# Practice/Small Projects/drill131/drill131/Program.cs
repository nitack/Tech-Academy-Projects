using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1. Make the Employee class take a generic type parameter.

//2. Add a property to the Employee class called "things" and have its data type be a generic list matching the generic type of the class.

//3. Instantiate an Employee object with type "string" as its generic parameter.Assign a list of strings as the property value of Things.

//4. Instantiate an Employee object with type "int" as its generic parameter.Assign a list of integers as the property value of Things.

//5. Create a loop that prints all of the Things to the Console.

namespace drill131
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employeeS = new Employee<string>
            {
                Things = new List<string>()
            };
            employeeS.Things.Add("Ryan");
            employeeS.Things.Add("Alex");
            employeeS.Things.Add("Chris");

            Employee<int> employeeI = new Employee<int>
            {
                Things = new List<int>()
            };
            employeeI.Things.Add(5);
            employeeI.Things.Add(6);
            employeeI.Things.Add(7);

            employeeS.Things.ForEach(Console.WriteLine);
            employeeI.Things.ForEach(Console.WriteLine);
            Console.ReadLine();
        }
    }
}
