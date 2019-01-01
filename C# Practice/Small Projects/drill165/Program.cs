using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1. Ask the user for his age.

//2. Display the year user born.

//3. Exceptions must be handled using "try .. catch".

//4. Display appropriate error messages if user enters zero or negative numbers.

//5. Display a general message if exception caused by anything else.

namespace drill165
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime moment = DateTime.Now;
            int year = moment.Year;
            Console.WriteLine("Hello, what is your age in years?");
            try
            {
                int age = Convert.ToInt32(Console.ReadLine());
                int birthYear = year - age;
                if (age > 0)
                {
                    Console.WriteLine("Meaning you were born in {0}.", birthYear);
                }
                else
                {
                    Console.WriteLine("I'm sorry, your age cannot be zero or a negative number.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("You must enter a whole number without any text.");
            }
            catch (Exception)
                {
                Console.WriteLine("I'm sorry, an unspecified error occured.  Please contact The Tech Academy @ 971.901.9635.");
            }
            Console.ReadLine();
        }
    }
}
