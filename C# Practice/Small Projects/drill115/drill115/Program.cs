using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1. Create a class. In that class, create a method that takes two integers as parameters.
//   Make one of them optional.Have the method do a math operation and return a integer result.

//2. In the Main() method of the console app, instantiate the class.

//3. Ask the user to input two numbers, one at a time.Let them know they need not enter 
//   anything for the second number.

//4. Call the method in the class, passing in the one or two numbers entered.

//5. Try various combinations of numbers on the code, including having no second number.

namespace drill115
{
    class Program
    {
        static void Main(string[] args)
        {
            Maths opps = new Maths();

            Console.WriteLine("Pick a number");
            int userNum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick another number, or don't...");
            string userNum2 = Console.ReadLine();
            if (userNum2 == null)
            {
                int resultAdd = Maths.Addition(userNum1);
                Console.WriteLine(resultAdd);
            }
            else
            {
                int intInput = (Convert.ToInt32(userNum2));
                int resultAdd = Maths.Addition(userNum1, intInput);
                Console.WriteLine(resultAdd);
            }
            Console.ReadLine();
        }
    }
}
