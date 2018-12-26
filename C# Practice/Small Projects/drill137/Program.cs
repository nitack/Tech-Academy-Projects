using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drill137
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number()
            {
                Amount = (decimal)123.45
            };

            Console.WriteLine("The value of Amount is {0}", number.Amount);
            Console.ReadLine();
        }
    }
}
