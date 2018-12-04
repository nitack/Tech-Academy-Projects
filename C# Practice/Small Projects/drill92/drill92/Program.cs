using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drill92
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            
            Console.WriteLine("Please enter the package weight:");
            int weight = Convert.ToInt16(Console.ReadLine());
            if (weight > 50)
                {
                    Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                    Console.ReadLine();
                }
            else
                {
                    Console.WriteLine("Please enter the package width:");
                    int width = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Please enter the package height:");
                    int height = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Please enter the package length:");
                    int length = Convert.ToInt16(Console.ReadLine());
                    int dimension = width + height + length;
                    if (dimension >= 50)
                        {
                            Console.WriteLine("Package too big to be shipped via Package Express.");
                            Console.ReadLine();
                        }
                    else
                        {
                            int cost = ((dimension * weight) / 100);
                            Console.WriteLine("Your estimated total for shipping this package is: " + cost);
                            Console.WriteLine("Thank you.");
                            Console.ReadLine();
                        }
                }
        }
    }
}
