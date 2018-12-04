using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drill97
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Pick a word...");
            string word1 = Console.ReadLine();
            Console.WriteLine("Pick another word...");
            string word2 = Console.ReadLine();
            Console.WriteLine("Pick one more word...");
            string word3 = Console.ReadLine();
            Console.WriteLine(word1 + " " + word2 + " " + word3);
            string uword = word1.ToUpper();
            Console.WriteLine(uword);
            StringBuilder sb = new StringBuilder("");
            Console.WriteLine("Write one sentence:");
            sb.Append(Console.ReadLine());
            Console.WriteLine("Write another sentence:");
            sb.Append(" " + Console.ReadLine());
            Console.WriteLine("Write one more sentence:");
            sb.Append(" " + Console.ReadLine());
            Console.WriteLine(sb);
            Console.ReadLine();

        }
    }
}
