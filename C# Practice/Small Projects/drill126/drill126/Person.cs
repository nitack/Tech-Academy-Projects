using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drill126
{
    public abstract class Person
    {

        public abstract void SayName();


        public string firstName { get; set; }
        public string lastName { get; set; }
    }
}
