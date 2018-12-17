using System;
using System.Collections.Generic;


namespace drill103
{
    class Program
    {
        static void Main()
        {
            // task 1: Create a one-dimensional Array of strings. Ask the user to input 
            //some text. Create a loop that goes through each string in the Array, adding 
            //the user’s text to the string. Then create a loop that prints off each 
            //string in the Array on a separate line.
            string[] stringArray = new string[] { "index Zero", "index One", "index Two", "index Three", "index Four" };
            Console.WriteLine("Write three words");
            string userWords = Console.ReadLine();
            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] = stringArray[i] + " " + userWords;
            }
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i]);
            }
            Console.ReadLine();

            //Task 2: create an infinite loop
            //for(int i=0; i = (i + 1); i++)
            //    {
            //    Console.WriteLine("To infinity...");
            //}

            //Task 3: Fix the loop
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("To infinity...");
            }
            Console.WriteLine("and beyond!");
            Console.ReadLine();

            //Task 4: Create a loop where the comparison used to determine whether to continue iterating the loop is a “<” operator.
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("To infinity...");
            }
            Console.WriteLine("and beyond!");
            Console.ReadLine();

            //Task 5: Create a loop where the comparison used to determine whether to continue iterating the loop is a “<=” operator.
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine("To infinity...");
            }
            Console.WriteLine("and beyond!");
            Console.ReadLine();


            //Task 6: Create a List of strings where each item in the list is unique.
            //Ask the user to select text to search for in the List.  Create a loop that 
            //iterates through the list and then displays the index of the array that 
            //contains matching text on the screen.

            List<string> stringList = new List<string>();
            stringList.Add("The Hobbit");
            stringList.Add("The Fellowship of the Ring");
            stringList.Add("The Two Towers");
            stringList.Add("The Return of the King");

            Console.WriteLine("Please type in 'Return' to search for a book.");
            string bookName = Console.ReadLine();
            for (int i = 0; i < stringList.Count; i++)
            {
                if (stringList[i].Contains(bookName))
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();



            //Task 7: Add code to that above loop that tells a user if they put in text that isn’t in the List.

            List<string> stringList2 = new List<string>();
            stringList2.Add("The Hobbit");
            stringList2.Add("The Fellowship of the Ring");
            stringList2.Add("The Two Towers");
            stringList2.Add("The Return of the King");
            int count = 0;
            
            Console.WriteLine("Please type in a word to see if any of our titles include that word.");
            string bookName2 = Console.ReadLine();
            for (int i = 0; i < stringList2.Count; i++)
            {
                if (stringList2[i].Contains(bookName2))
                {
                    count++;
                    Console.WriteLine(i);
                }
            }
            if (count == 0)
            {
                Console.WriteLine("no book titles contain that word");
            }
            Console.ReadLine();


            //Task 8: Add code to that above loop that stops it from executing once a match has been found.

            List<string> thirdList = new List<string>();
            thirdList.Add("The Hobbit");
            thirdList.Add("The Fellowship of the Ring");
            thirdList.Add("The Two Towers");
            thirdList.Add("The Return of the King");
            int count2 = 0;

            Console.WriteLine("Please type in a word to see if any of our titles include that word.");
            string bookName3 = Console.ReadLine();
            for (int i = 0; i < thirdList.Count && count2 > 0; i++)
            {
                if (thirdList[i].Contains(bookName3))
                {
                    count2++;
                    Console.WriteLine(i);
                }
            }
            if (count2 == 0)
            {
                Console.WriteLine("no book titles contain that word");
            }
            Console.ReadLine();

            //Task 9: Create a List of strings that has at least two identical strings in the List. 
            //Ask the user to select text to search for in the List.Create a loop that iterates through 
            //the list and then displays the indices of the array that contain matching text on the screen.

            List<string> someList = new List<string>();
            someList.Add("Elantris");
            someList.Add("Ender's Game");
            someList.Add("Ender's Shadow");
            someList.Add("Columbus Day");
            someList.Add("Elantris");

            Console.WriteLine("Please type in 'Elantris' to see all indices that include that title");
            string someName = Console.ReadLine();
            for (int i = 0; i < someList.Count; i++)
            {
                if (someList[i].Contains(someName))
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();


            //Task 10: Add code to that above loop that tells a user if they put in text that isn’t in the List.

            List<string> someList2 = new List<string>();
            someList2.Add("Elantris");
            someList2.Add("Ender's Game");
            someList2.Add("Ender's Shadow");
            someList2.Add("Columbus Day");
            someList2.Add("Elantris");
            int counter = 0;

            Console.WriteLine("Please type in 'Elantris' to see all indices that include that title");
            string someName2 = Console.ReadLine();
            for (int i = 0; i < someList2.Count; i++)
            {
                if (someList2[i].Contains(someName2))
                {
                    counter++;
                    Console.WriteLine(i);
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("no book titles contain that word");
            }
            Console.ReadLine();

            //Task 11: Create a List of strings that has at least two identical strings in the List. Create a 
            //foreach loop that evaluates each item in the list, and displays a message showing the string and 
            //whether or not it has already appeared in the list.

            List<string> dorathysList = new List<string> { "Lions", "Tigers", "Bears", "Oh, my!", "Lions", "Tigers", "Bears", "Oh, my!" };
            List<string> dumpList = new List<string>();

            Console.WriteLine("Just hit enter...");
            foreach (string line in dorathysList)
            {
                if (dumpList.Contains(line))
                {
                    Console.WriteLine(line + " is being added to the list, but it is also already on there.");
                }
                else
                {
                    Console.WriteLine(line + " is being added to the list.");
                }
                dumpList.Add(line);
            }
            Console.ReadLine();


        }
    }
}
