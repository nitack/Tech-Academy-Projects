using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drill66
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Pick a number, any number...");
            int userNum1 = Convert.ToInt32(Console.ReadLine());
            int output1 = userNum1 * 50;
            Console.WriteLine(output1);
            
            Console.WriteLine("Pick a number, any number...");
            int userNum2 = Convert.ToInt32(Console.ReadLine());
            int output2 = userNum2 + 25;
            Console.WriteLine(output2);
            
            Console.WriteLine("Pick a number, any number...");
            double userNum3 = Convert.ToDouble(Console.ReadLine());
            double output3 = userNum3 / 12.5;
            Console.WriteLine(output3);
            
            Console.WriteLine("Pick a number, any number...");
            int userNum4 = Convert.ToInt32(Console.ReadLine());
            bool output4 = userNum4 > 50;
            Console.WriteLine(output4);
            
            Console.WriteLine("Pick a number, any number...");
            int userNum5 = Convert.ToInt32(Console.ReadLine());
            int output5 = userNum5 % 7;
            Console.WriteLine(output5);
            Console.ReadLine();


        }
    }
}
