using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatSum
{
    internal class Program
    {
        static int CalCum(int aNumber)
        {
            //return a sum

            int returnValue = 0; //declare return value to hold value to return
            int sum = 0;

            for (int i = 0; i<aNumber; i+=2)
            {
                sum = sum + i;
            }
            returnValue = sum;
            

            return sum;
        }
        static void Main(string[] args)
        {
        
            //ask user to input
            int number =0;
            string userInput = "";
            bool continueRun = true; //declare a flag
            do
            {
                Console.WriteLine("Input a number");

                userInput = Console.ReadLine();

                if (userInput.ToLower().StartsWith("q"))
                {
                    continueRun = false;
                }
                else
                {
                    number = Convert.ToInt32(userInput);
                    Console.WriteLine("SUM of even numbers" + CalCum(number));
                }
            } while (continueRun);

            Console.ReadLine();

           
            
            //print out the sum of all even number less than number
        }
    }
}
