using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drill117
{
    class Maths
    {
        //what is the purpose of a void method?  In order to show that it performed the action I had to have the Console.
        //WriteLine within the method, rather than returning the value and then doing Console.WriteLine.
        public void Div(int input)
        {
            Console.WriteLine(input / 2);
        }

        public void Div(int input, int input2)
        {
            Console.WriteLine((input / 2) * input2);
        }

        public void DivingOut(int divisor, out int times)
        {
            times = 0;
            int running = divisor; 
            for (int i = 0; running > 1; i++)
            {
                times++;
                running = running - 2;
            }
        }

    }
}
