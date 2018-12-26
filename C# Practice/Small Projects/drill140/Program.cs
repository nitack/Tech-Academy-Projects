using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drill140
{
    class Program
    {
        static void Main(string[] args)
        {

            //int count = deck.Cards.Count(x => x.Face == Face.Ace);

            //List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList();

            Employee employee = new Employee();

            List<Employee> employees = new List<Employee>()
            {
                new Employee{ FirstName="Joe", LastName="Bishop", Id=1},
                new Employee{ FirstName="Ryan", LastName="Day", Id=2},
                new Employee{ FirstName="Alex", LastName="Chew", Id=3},
                new Employee{ FirstName="Adam", LastName="Schuetz", Id=4},
                new Employee{ FirstName="Chris", LastName="Takimori", Id=5},
                new Employee{ FirstName="Joe", LastName="Hobba", Id=6},
                new Employee{ FirstName="Janelle", LastName="Matthews", Id=7},
                new Employee{ FirstName="Travis", LastName="Day", Id=8},
                new Employee{ FirstName="Kevin", LastName="Shin", Id=9},
                new Employee{ FirstName="Joe", LastName="Johnson", Id=10}
            };

            foreach ( Employee i in employees)
            {
                if (i.FirstName.Contains("Joe"))
                {
                    Console.WriteLine(i.FirstName);
                    Console.WriteLine(i.LastName);
                }
            }
            Console.ReadLine();

            List<Employee> joes = employees.Where(x => x.FirstName.Contains("Joe")).ToList();
            foreach (Employee i in joes)
            {
                Console.WriteLine(i.FirstName);
                Console.WriteLine(i.LastName);
            }
            Console.ReadLine();




            List<Employee> ids = employees.Where(x => x.Id > 5).ToList();
            foreach (Employee i in ids)
            {
                Console.WriteLine(i.FirstName);
                Console.WriteLine(i.LastName);
                Console.WriteLine(i.Id);
            }
            Console.ReadLine();
        }
    }
}
