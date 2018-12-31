using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drill156
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentTime = DateTime.Now;
            Console.WriteLine(currentTime);
            Console.WriteLine("Please pick how many hours you would like to add to the time.");
            int userIncriment = Convert.ToInt32(Console.ReadLine());
            DateTime newTime = currentTime.AddHours(userIncriment);
            Console.WriteLine("The current time is: {0} \n In {1} hours it will be {2}.", currentTime, userIncriment, newTime);


            
            Console.ReadLine();
        }
    }
}
