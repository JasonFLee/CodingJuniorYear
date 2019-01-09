using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLeeHangman
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rand = new Random();
            ////Random object
            int randoMnumber = rand.Next(0, 20);
            string[] week = new string[20];
            //Create an array of words
            week[0] = "ready";
            week[1] = "women";
            week[2] = "phone";
            week[3] = "peter";
            week[4] = "raise";
            week[5] = "prime";
            week[6] = "quite";
            week[7] = "scoopie";
            week[8] = "japan";
            week[9] = "child";
            week[10] = "buyer";
            week[11] = "cheap";
            week[12] = "chart";
            week[13] = "salty";
            week[14] = "basis";
            week[15] = "amaze";
            week[16] = "scoopidypoop";
            week[17] = "hello";
            week[18] = "sandal";
            week[19] = "wonder";

            //string to hold our randomly relected from array word
            string chosenWord = week[randoMnumber];
            Console.WriteLine(chosenWord);
            //create a list of characters to hold our guesses
            List<char> guesses = new List<char>();



            //create a boolean to test whether of not our solution is currently correct
            bool solutioncorrect = false ;
            //Create a counter to count the number of failed guesses
            int failedGuesses = 0;
            //Do while failed guesses < 6 and sollution is not correct
            do
            {
                //Print out hidden version of our string. If we print a single "_"then our solution is curently not correct
                solutioncorrect = true;
               
                for(int i = 0; i < chosenWord.Length; i++)
                {
                    if (guesses.Contains(chosenWord[i]))
                    {
                        Console.Write(chosenWord[i]);
                    }
                    //if our solution is currently not correct then print to the user guesses
                    else
                    {
                        Console.Write("_ ");
                        solutioncorrect = false; 
                    }
                }
                Console.WriteLine("");
                if(solutioncorrect == false)
                {
                    //print to user the guesses
                    foreach (char item in guesses)
                    {
                        Console.Write(item);
                    }




                    //ask the user for input
                    Console.WriteLine("");
                    Console.WriteLine("Guess");

                    char input = Console.ReadLine()[0];
                    guesses.Add(input);
                    //if list of guesses does not include input then
                    if (chosenWord.Contains(input)== false)
                    {

                        failedGuesses = failedGuesses + 1;
                    }
                    //increment failed guesses counter
                }
            } while (failedGuesses< 6 && solutioncorrect == false);
            

            if(solutioncorrect == true)
            {
                Console.WriteLine("You got it in " + failedGuesses + " tries");
            }
            else if(failedGuesses >= 6)
            {

                Console.WriteLine("You lost");
            }
            Console.ReadLine();


        }

    }
}




    
   
       





