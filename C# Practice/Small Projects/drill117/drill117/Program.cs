using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1. Create a class. In that class, create a void method that outputs an integer.Have the method divide the data passed to it by 2.

//2. In the Main() method, instantiate that class.

//3. Have the user enter a number.Call the method on that number.Display the output to the screen. It should be the entered number, divided by two.

//4. Create a method with output parameters.

//5. Overload a method.

//6. Declare a class to be static.

namespace drill117
{
    class Program
    {
        static void Main(string[] args)
        {
            Maths opps = new Maths();


            Console.WriteLine("Pick a number");
            int userNum = Convert.ToInt32(Console.ReadLine());
            opps.Div(userNum);

            Console.WriteLine("Pick another number");
            int userNum2 = Convert.ToInt32(Console.ReadLine());
            opps.Div(userNum, userNum2);

            opps.DivingOut(userNum, out int times);
            Console.WriteLine(userNum + " can have 2 subtracted from it {0} times.", times);

            Console.WriteLine("How long is each side of the square?");
            int a = Convert.ToInt32(Console.ReadLine());
            int resultArea = MoreMaths.SquareArea(a);
            Console.WriteLine("The area of a square with each side " + a + " long is " + resultArea);
            
            Console.ReadLine();
 
            

        }
    }
}
