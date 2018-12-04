using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drill94
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Guess my weight...");
            int weight = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = weight == 235;

            do
            {
                switch (weight)
                {
                    case 0:
                        Console.WriteLine("Zero... Really?");
                        Console.WriteLine("Guess again...");
                        weight = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 1:
                        Console.WriteLine("One... Really?");
                        Console.WriteLine("Guess again...");
                        weight = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 235:
                        Console.WriteLine("You are correct, 235 pounds.");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("Not quite... try again.");
                        Console.WriteLine("Guess again...");
                        weight = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!isGuessed);

            Console.ReadLine();
        }
    }
}
