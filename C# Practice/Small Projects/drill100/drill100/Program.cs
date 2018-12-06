using System;
using System.Collections.Generic;


namespace drill100
{
    class Program
    {
        static void Main()
        {

            string[] stringArray = new string[] { "index Zero", "index One", "index Two", "index Three", "index Four"};
            Console.WriteLine("Choose an index number between 0 and 4...");
            int userString = Convert.ToInt16(Console.ReadLine());
            if (userString >= 0 && userString <= 4)
            {
                Console.WriteLine(stringArray[userString]);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("That index number is not between 0 and 4.");
                Console.ReadLine();
            }

            int[] intArray = new int[] { 2, 4, 6, 8, 10 };
            Console.WriteLine("Choose an index number between 0 and 4...");
            int userInt = Convert.ToInt16(Console.ReadLine());
            if (userInt >= 0 && userInt <= 4)
            {
                Console.WriteLine(intArray[userInt]);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("That index number is not between 0 and 4.");
                Console.ReadLine();
            }

            List<string> stringList = new List<string>();
            stringList.Add("First index in the list");
            stringList.Add("Second index in the list");
            stringList.Add("Third index in the list");
            stringList.Add("Fourth index in the list");
            stringList.Add("Fifth index in the list");

            Console.WriteLine("Choose an index number between 0 and 4...");
            int userListNum = Convert.ToInt16(Console.ReadLine());
            if (userListNum >= 0 && userListNum <= 4)
            {
                Console.WriteLine(stringList[userListNum]);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("That index number is not between 0 and 4.");
                Console.ReadLine();
            }


        }
    }
}
