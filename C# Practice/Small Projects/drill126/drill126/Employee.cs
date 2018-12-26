using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drill126
{
    public class Employee : Person, IQuittable
    {

        public override void SayName()
        {
            Console.WriteLine("Name: {0} {1}", firstName, lastName);
        }

        public void Quit()
        {
            Console.WriteLine("Keep this up and someone will quit");
        }

    }
}
