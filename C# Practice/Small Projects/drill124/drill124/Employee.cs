using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drill124
{
    public class Employee : Person
    {
        
        public override void SayName()
        {
            Console.WriteLine("Name: {0} {1}", firstName, lastName);
        }


    }
}
