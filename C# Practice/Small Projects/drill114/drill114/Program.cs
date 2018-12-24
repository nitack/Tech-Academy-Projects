using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1. Create a class. In that class, create a method that will take in an integer, 
//   do a math operation to it and then return the answer as an integer.

//2. In the Main() method of the console app, instantiate the class and call the 
//   one method, passing in an integer, such as 12. Then display the result to the screen.

//3. Add a second method to the class, with the same name, that will take in a decimal, 
//   do a different math operation to it and then return the answer as an integer.

//4. In the Main() method of the console app, instantiate the class and call the 
//   second method, passing in a decimal. Display the result to the screen.

//5. Add a third method to the class, with the same name, that will take in a 
//   string, convert it to an integer if possible, do a different math operation 
//   to it and then return the answer as an integer.

//6. In the Main() method of the console app, instantiate the class and call the 
//   third method, passing in a string that equates to an integer.Display the result to the screen.

namespace drill114
{
    class Program
    {
        static void Main(string[] args)
        {
            Maths opps = new Maths();

            Console.WriteLine("Pick a number");
            int userNum1 = Convert.ToInt32(Console.ReadLine());
            int resultAdd = Maths.Addition(userNum1);
            Console.WriteLine("Your number was " + userNum1 + ", added to 5 the result is " + resultAdd);

            Console.WriteLine("Pick another number");
            decimal userNum2 = Convert.ToDecimal(Console.ReadLine());
            int resultAdd2 = Maths.Addition(userNum2);
            Console.WriteLine("Your number was " + userNum2 + ", added to 10 the result is " + resultAdd2);

            Console.WriteLine("Pick another number");
            string userNum3 = Console.ReadLine();
            int resultAdd3 = Maths.Addition(userNum3);
            Console.WriteLine("Your number was " + userNum2 + ", added to 20 the result is " + resultAdd3);

            Console.ReadLine();
        }
    }
}
