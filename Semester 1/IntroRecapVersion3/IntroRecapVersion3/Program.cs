﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroRecap
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Variables
            // ************* Variables *************** //

            //Create a variable of type int called id. Initialize it to 75.
            int id = 75;
            //Create a variable of type string called name. Initialize it to your full name.
            string name = "jason lee";
            //Create a variable of type bool called isValid. Initialize it to true.
            bool is_Valid = true;
            //Create a variable of type int called userID. Don't initialize this value. (In C#, ints default to 0)
            int userId;
            //Create a variable of type string called state. Don't initialize this value. (In C#, strings default to null)
            string state;
            //Create a variable of type bool called hasRan. Don't initialize this value. (In C#, booleans default to false)
            bool hasRan;
            //Create a variable of type char called myCharacter. Initialize this value to "a".
            char mrCharacter = 'a';
            //Create a variable of type double called myDouble. Initialize this value to 3.14
            double myDouble = 3.14;
            //Create a variable of type float called myFloat. Initialize this value to 3.14 (cannot convert double to float, check 1.0 slides).
            float myFloat = 3.14f;
            //Create a variable of type Random called rand. Initialize it to a new Random Object.
            Random rand = new Random();
            #endregion
            #region Conditionals
            // ************ Conditionals ************* //

            //Create a variable of type bool called isValid. Initialize it to true.
            bool isValid = true;
            //if isValid is true, then console writeline "isValid is true"
            if (isValid == true)
            {
                Console.WriteLine("ISVALID IS TRUEEE");
            }
            //else if isValid is not true, then console writeline "isValid is not true"
            if (isValid != true)
            {
                Console.WriteLine("ISVALID IS TRUEEE");
            }
            //Create a variable of type int called x. Initialize it to 75.
            int x = 75;
            //Create a variable of type int called y. Initialize it to 100.
            int y = 100;
            //If x is greater than y, then console writeline "X is Greater than Y"
            if (x > y)
            {
                Console.WriteLine("X IS GREATER THAN Y");
            }
            //else if x is equal to y, then console writeline "X is equal to Y"
            else if (x == y)
            {
                Console.WriteLine("X IS EQUAL TO Y");
            }

            //else, then console writeline "X is less than Y"
            else
            {
                Console.WriteLine("X IS LESS THAN Y");
            }
            //Create a variable of type string called country. Initialize it to "Mexico".
            string country = "Mexico";
            //Create a variable of type int called age. Initialize it to 18.
            int age = 18;
            //If country is "Mexico" and age is greater than or equal to 18 then console writeline "You can legally drive"
            if (country == "Mexico" && age >= 18)
            {
                Console.WriteLine("You can legally drive");
            }
            //else if country is not "Mexico" and age is greater than or equal to 16 then console writeline "You can legally drive"
            else if (country != "Mexico" && age >= 16)
            {
                Console.WriteLine("You can legally drive");
            }
            //else console writeline "you cannot legally drive"
            else
            {
                Console.WriteLine("You cannot legally drive");
            }

            #endregion
            #region Loops
            // **************** Loops **************** //

            //for loop starting at i = 0 and continue while i < 10, incrementing by 1. Console writeline the value of i each time.
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            //for loop starting at i = 0 and continue while i < 30, incrementing by 2. Console writeline the value of i each time.
            for (int i = 0; i < 30; i += 2)
            {
                Console.WriteLine(i);
            }
            //for loop starting at i = 30 and continue while i >= 0, decrementing by 1. Console writeline the value of i each time.
            for (int i = 30; i >= 30; i--)
            {
                Console.WriteLine(i);
            }
            //for loop starting at i = 30 and continue while i > 0, decrementing by 3. Console writeline the value of i each time.
            for (int i = 30; i >= 30; i--)
            {
                Console.WriteLine(i);
            }
            //Create an int variable called index, initialize it to 0.
            int index = 0;
            //while index < 10 Console writeline index. increment index
            while (index < 10)
            {
                Console.WriteLine(index);
            }
            //reset index variable to 0
            index = 0;
            //while index < 0 console writeline index, increment index
            while (index < 0)
            {
                Console.WriteLine(index);
            }
            //Reset index variable to 0
            index = 0;
            //do-while index < 10 console writeline index., increment index
            do
            {
                Console.WriteLine(index);
            } while (index < 10);
            //reset index variable to 0
            index = 0;
            //do-while index < 0 console writeline index, increment index
            do
            {
                Console.WriteLine(index);
            } while (index < 0);
            //Create an int variable called input, initialize to 0
            int input = 0;
            //Accept user input with Console.ReadLine and parse it into an integer with int.Parse. Store in input variable.
            input = int.Parse(Console.ReadLine());
            //do-while input does not equal -1, console writeline "Input -1 to end program, input any other number to continue"
            do
            {
                Console.WriteLine("Input -1 to end program, input any other number to continue");
            } while (input != -1);
            #endregion
            #region Arrays
            // *************** Arrays **************** //

            //Create an array of type int and of size 10 called intArray. Don't initialize any data. (Remember, ints default to 0 so you now have an array of 10 0's.)
            int[] intArray = new int[10];
            //Create an array of type string and of size 5 called stringArray. Don't initialize any data.
            string[] stringArray = new string[5];
            //For the following, change each index individually. Do not use a loop or assignment on declaration
            //Populate intArray with data following the formula: data = index * 3. IE the 3rd element of intArray will equal 9.
            intArray[0] = 3;
            intArray[1] = 6;
            intArray[2] = 9;
            intArray[3] = 12;
            intArray[4] = 15;
            intArray[5] = 18;
            intArray[6] = 21;
            intArray[7] = 24;
            intArray[8] = 27;
            intArray[9] = 30;
            //Populate stringArray with the following data: firstName, lastName, city, state, country
            stringArray[1] = "firstName";
            stringArray[2] = "lastName";
            stringArray[3] = "city";
            stringArray[4] = "state";
            stringArray[5] = "country";
            //for the following use a loop to assign the data into the arrays.
            //set each index data of intArray using the following formula: data = index * 2 + 1. IE the 3rd element will equal 7
            for (int i = 0; i < 10; i++)
            {
                intArray[i] = i * 2 + 1;
            }

            //set each index data of stringArray to "The current index is i" where i is the actual value of i
            for (int j = 0; j < 5; j++)
            {
                stringArray[j] = "the current index is" + j;
            }
            //reset intArray to be a new int array of size 5. In the same line (hint, use { }) set the values to 0,1,2,3,4
            intArray = new int[] { 0, 1, 2, 3, 4 };
            //reset stringArray to be a new string array of size 3. In the same line (hint, use { }) set the values to "buddy", "guy", "Friend"
            stringArray = new string[] { "buddy", "guy", "friend" };
            //for int i = 0, continue for the length of intArray, and increment i + 1, console writeline the value of intArray
            for (int p = 0; p < 5; p++)
            {
                Console.WriteLine(intArray[p]);
            }
            //for int i = 0, continue for the length of stringArray, and increment i + 1, console writeline the value of stringArray
            for (int k = 0; k < 3; k++)
            {
                Console.WriteLine(stringArray[k]);
            }
            //iterate over (AKA use a for loop) intArray similarly to what you did above, but do it backwards. Print the last index first, and the 0th index last.            //iterate over (AKA use a for loop) stringArray similarly to what you did above, but do it backwards. Print the last index first, and the 0th index last.
            for (int p = 0; p < 5; p--)
            {
                Console.WriteLine(intArray[p]);
            }
            #endregion
        }
    }
}
