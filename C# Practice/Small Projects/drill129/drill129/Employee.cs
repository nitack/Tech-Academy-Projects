using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drill129
{
    class Employee : Person
    {

        public int Id { get; set; }

        public static bool operator == (Employee employee, Employee employee2)
        {
            return (employee.Id == employee2.Id);
        }
        public static bool operator != (Employee employee, Employee employee2)
        {
            return (employee.Id != employee2.Id);
        }
    }
}
