using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreReqTest
{
    class Program
    {
        static void Main(string[] args)
        {
            bool stop = false;
            do
            {
                
                Console.WriteLine("Please enter an integer for the number you want to choose:");
                Console.WriteLine("1. Print Hello World");
                Console.WriteLine("2. What two integers do you want to add");
                Console.WriteLine("3. Calculate the area of a circle given just the radius ");
                Console.WriteLine("4. Calculate the are of a triangle given the length of all three sides");
                Console.WriteLine("5. Given an integer, draw a square using the asciii character x that has a width of n");
                Console.WriteLine("6. Given an integer. draw a hollow square using the ASCII charcter x that has a width of n");
                Console.WriteLine("7. Given two integer variables, swap values");
                Console.WriteLine("8. Reverse String using a for loop");
                Console.WriteLine("9. End Program");
                int input = int.Parse(Console.ReadLine());
                if(input == 9)
                {
                    break;
                }
                if (input == 1)
                {
                    Console.WriteLine("Hello World");
                 }
                if (input == 2)
                {
                    Console.WriteLine("whats the first number?");
                    int input2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("whats the second number?");
                    int input3 = int.Parse(Console.ReadLine());
                    Console.WriteLine(input2 + input3);
                }
            
                if (input == 3)
                {
                    Console.WriteLine("whats the radius?");
                    int radius = int.Parse(Console.ReadLine());
                    Console.WriteLine(Math.PI * (radius) * (radius));
                }

                if (input == 4)
                {
                    Console.WriteLine("whats the first side?");
                    float side1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("whats the second side?");
                    float side2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("whats the third side?");
                    float side3 = int.Parse(Console.ReadLine());
                    float p = ((side1 + side2 + side3) / 2);
                    double blah = (p - side1)*(p - side2)*(p - side3);
                    Console.WriteLine(Math.Sqrt(blah));
                  
                }

                if (input == 5)
                {
                    Console.WriteLine("whats the n length?");
                    int sidelength = int.Parse(Console.ReadLine());
                    for(int x = 0; x < sidelength; x++)
                    {
                        for (int y = 0; y < sidelength; y++)
                        {
                            Console.Write("x");
                        }
                        Console.WriteLine("");
                    }
                  
                }

                if (input == 6)
                {
                    Console.WriteLine("whats the n length?");
                    int sidelength = int.Parse(Console.ReadLine());                          
                   for (int i = 1; i <= sidelength; i++)
                    {
                        for (int j = 1; j <= sidelength; j++)
                        {
                            if (i == 1 || i == sidelength || j == 1 || j == sidelength)
                            {
                                Console.Write("x");
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                                
                        }
                        Console.WriteLine();
                    }
                }

                    if (input == 7)
                {
                    Console.WriteLine("whats the first integer?");
                    int integer1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("whats the second integer?");
                    int integer2 = int.Parse(Console.ReadLine());
                    int temp;
                    temp = integer1;
                    integer1 = integer2;
                    integer2 = temp;
                    Console.WriteLine("the first integer is: "+ integer1);
                    Console.WriteLine("the second integer is: " + integer2);

                }

                if (input == 8)
                {
                    Console.WriteLine("what is your string?");
                    string givenstring = Console.ReadLine();
                    int l = givenstring.Length;
                    for(int x  = 1; x < givenstring.Length+ 1; x++)
                    {
                        Console.Write(givenstring[l-x]);
                    }
                }

            } while (stop == false);
           
        }
    }
}
