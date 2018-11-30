using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int comboTotal = total + otherTotal;
            //Console.WriteLine("the combination total is" + comboTotal.ToString());
            ////Console.ReadLine();

            //int remainder = 10 % 3;
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            int roomTemperature = 70;
            int currTemp = 70;


            bool isWarm = currTemp >= roomTemperature;
            Console.WriteLine(isWarm);
            Console.ReadLine();

        }
    }
}
