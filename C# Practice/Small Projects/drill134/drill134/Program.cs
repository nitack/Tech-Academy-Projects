using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1. Create an enum for the days of the week.

//2. Prompt the user to enter the current day of the week.

//3. Assign the value to a variable of that enum data type you just created.

//4. Wrap the above statement in a try/catch block and have it print "Please 
//   enter an actual day of the week." to the console if an error occurs.

//Note - In the last video, we explained the underlying concepts behinds enums.
//Nobody knows everything about a programming language and its features, so it's 
//our job as programmers to do research on how to work with various data types, 
//classes and libraries. For this drill, you'll need to do some additional 
//research on how to parse enums.

namespace drill134
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the current day of the week");
            string userDay = Console.ReadLine();

            Days day;
            try
            {
                day = (Days)Enum.Parse(typeof(Days), userDay);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Nope. Please enter an actual day of the week.");
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
        public enum Days
        {
            Monday=1,
            Tuesday=2,
            Wednesday=3,
            Thursday=4,
            Friday=5,
            Saturday=6,
            Sunday=7
        }
    }
}
