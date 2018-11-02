using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JleeGuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare a random variable from 0 to 1000
            
            Random rand = new Random();
            int number = rand.Next(0, 1000);
            Console.WriteLine(number);
            int x = 0;
            int poopityscoop = 0;
            do
            { 
                //Asks for a number from 0 to 1000
              x = x + 1; 

                Console.WriteLine("Guess:");
                
                int input = int.Parse(Console.ReadLine());
                //if the random variable > the guess, print "guess higher" and add one to the variable "count"
                //if the random variable < the guess, print "guess lower" and add one to the variable "count"
                //if the random variable == the guess then print "correct" 
                if (input < number)
                {
                    Console.WriteLine("Guess Higher");
                   
                }
                else if (input > number)
                {
                   Console.WriteLine("Guess Lower");
                   
                }
                else if (input == number)
                {
                   Console.WriteLine("DONE");

                    Console.WriteLine("You tried " + x+ " number of times");
                    Console.ReadLine();
                    poopityscoop = 5;
                }

                //Print the count
                //End program 
            } while (poopityscoop != 5);

































                //int num = 1000;
                //do
                //{
                //    Console.WriteLine("*************************");
                //    string input = Console.ReadLine();
                //    if (input == "yes")
                //    {
                //        num = num / 2;

                //        Console.WriteLine(num);

                //    }
                //    else if (input == "no")
                //    {

                //        num = num / 2;
                //        num = num + 500;
                //        Console.WriteLine(num);
                //    }

                //} while (true);


            }
    }
}

