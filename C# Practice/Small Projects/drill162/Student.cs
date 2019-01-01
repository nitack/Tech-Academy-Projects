using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drill162
{
    public class Student
    {
        public Student(string name) : this(name, 135)
        {

        }

        public Student(string name, int schoolNum)
        {
            Name = name;
            School = schoolNum;
        }
        public string Name { get; set; }
        public int School { get; set; }
    }
}
