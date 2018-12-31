using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace drill154
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type some text to be added to a log file.");
            string userInput = Console.ReadLine();
            using (StreamWriter file = new StreamWriter(@"C:\users\Ryan\log.txt", true))
            {
                file.WriteLine(userInput);
            }
            string text = File.ReadAllText(@"C:\Users\Ryan\log.txt");
            Console.WriteLine("You wrote: {0}", text);
            Console.ReadLine();
        }
    }
}
