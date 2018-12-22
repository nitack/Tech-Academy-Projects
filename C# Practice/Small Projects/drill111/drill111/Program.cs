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
        public static int Main(string[] args)
        {
            Maths opps = new Maths();
            Console.WriteLine("Pick a number");
            public int userNum = Convert.ToInt32(Console.ReadLine());

            opps.Addition(int userNum)
        }
    }
}

