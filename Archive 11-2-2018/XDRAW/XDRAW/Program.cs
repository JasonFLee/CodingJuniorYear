using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XDRAW
{
    class Program
    {
        static void Main(string[] args)
        {
                bool done = false;
                while (done == false)
                {
                    Console.WriteLine("Enter the integer value for the action you want to preform ");
                    Console.WriteLine("1");
                    Console.WriteLine("2");
                    Console.WriteLine("3");
                    Console.WriteLine("4");
                    Console.WriteLine("5");
                Console.WriteLine("6");
                Console.WriteLine("7");
                Console.WriteLine("8");
                Console.WriteLine("9");

                string result = Console.ReadLine();
                    if (result == "1" )
                    {               
                        Console.WriteLine("X");        
                    }
                    else if (result == "2")
                    {





                        for(int i =0; i<3; i++)
                    {
                        for(int j =0; j <3; j++)
                        {
                            Console.Write("X");
                        }
                        Console.WriteLine();
                    }






                    }
                    else if (result == "3")
                    {
                        
                    }
                    else if (result == "4")
                    {
                        
                    }
                    else if (result == "5")
                    {
                     
                    }
                else if (result == "6")
                {

                }
                else if (result == "7")
                {

                }
                else if (result == "8")
                {

                }
                else if (result == "9")
                {

                }
                else
                    {
                        Console.WriteLine("PLEASE ENTER A VALID ANSWER");
                    }
                }
            }



        }
    }

