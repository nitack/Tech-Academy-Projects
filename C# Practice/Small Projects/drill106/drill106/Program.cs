using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drill106
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Create a list of integers. Ask the user for a number to divide each number in the list 
            //by.Write a loop that takes each integer in the list, divides it by the number the user 
            //entered, and displays the result to the screen.

            List<int> numList = new List<int> { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50, 55 , 60, 65, 70, 75, 80, 85, 90, 95, 100 };
            Console.WriteLine("We have a list of numbers counting by 5 to 100, please select a number to devide each number by.");
            int userNum = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numList.Count; i++)
            {
                int answer = (int) numList[i] / userNum;
                Console.WriteLine(numList[i] + " divided by " + userNum + " equals " + answer);
            }
            Console.ReadLine();

            //2.Run that code, entering in non - zero numbers as the user.Look at the displayed results.

            // the answers were rounded.

            //3.Run that code, entering in zero as the number to divide by.Note any error messages you get.

            // System.DivideByZeroException: 'Attempted to divide by zero.'

            //4.Run that code, entering in a string as the number to divide by.Note any error messages you get.

            // System.FormatException: 'Input string was not in a correct format.'

            //5.Now put the loop in a try/catch block.Below and outside of the try/catch block, make the 
            //program display a message to the display to let you know the program has emerged from the 
            //try/catch block and continued on with program execution.In the catch block, display the error 
            //message to the screen.Then try various combinations of user input: valid numbers, zero and a 
            //string.Ensure the proper error messages display on the screen, and that the code after the 
            //try/catch block gets executed.

            for (int i = 0; i < numList.Count; i++)
            {
                try
                {
                    int answer = (int)numList[i] / userNum;
                    Console.WriteLine(numList[i] + " divided by " + userNum + " equals " + answer);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Please type a whole number.");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("The laws of mathamatics are immutable.  You cannot divide by zero mortal!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("Catch/Try block completed.");
                }
            }
            Console.ReadLine();
        }
    }
}
