using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drill114
{
    class Maths
    {
        public static int Addition(int input)
        {
            return input + 5;
        }
        public static int Addition(decimal input)
        {
            return Convert.ToInt32(input + 10);
        }
        public static int Addition(string input)
        {
            return (Convert.ToInt32(input)) + 20;
        }
    }
}
