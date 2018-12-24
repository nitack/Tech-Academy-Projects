using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1. Create a class. In that class, create a void method that takes 
//   two integers as parameters.Have the method do a math operation 
//   on the first integer and display the second integer to the screen.

//2. In the Main() method of the console app, instantiate the class.

//3. Call the method in the class, passing in two numbers.

//4. Call the method in the class, specifying the parameters by name.

namespace drill113
{
    class Program
    {
        static void Main(string[] args)
        {
            Maths opps = new Maths();

            Console.WriteLine("Pick a number");
            int userNum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick another number");
            int userNum2 = Convert.ToInt32(Console.ReadLine());
            int resultAdd = Maths.Addition(userNum1, userNum2);

            Console.WriteLine("Your number was " + userNum1 + ", added to 5 the result is " + resultAdd);
            Console.ReadLine();
        }
    }
}
