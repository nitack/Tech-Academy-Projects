using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1. Create a class. In that class, create three methods, 
//   each of which will take one integer parameter in and 
//   return an integer.The methods should do some math 
//   operation on the received parameter.Put this class 
//   in a separate.cs file in the application.

//2. In the Main() program, ask the user what number they 
//   want to do the math operations on.

//3. Call each method in turn, passing the user input to 
//    the method.Display the returned integer to the screen.

namespace drill111
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Pick a number");
            int userNum = Convert.ToInt32(Console.ReadLine());
            int resultAdd = Maths.Addition(userNum);
            int resultSub = Maths.Subtraction(userNum);
            int resultMult = Maths.Multiply(userNum);

            Console.WriteLine("Your number was " + userNum + ", added to 5 the result is " + resultAdd);
            Console.WriteLine("Your number was " + userNum + ", 5 subtracted from it results in " + resultSub);
            Console.WriteLine("Your number was " + userNum + ", multiplied by 5 the result is " + resultMult);

            Console.ReadLine();

        }
    }
}

