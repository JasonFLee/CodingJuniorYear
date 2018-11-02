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
                string a = " ";
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
                Console.WriteLine();

                string result = Console.ReadLine();
                if (result == "1")
                {
                    Console.WriteLine();
                    Console.WriteLine("X");
                    Console.WriteLine();
                }
                else if (result == "2")
                {




                    Console.WriteLine();
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            Console.Write("X");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();






                }
                else if (result == "3")
                {
                    Console.WriteLine();
                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            Console.Write("X");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();

                }
                else if (result == "4")
                {
                    
                    for (int i = 0; i < 6; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (j == i|| j > i)

                                Console.Write(" ");

                            else
                                Console.Write("X");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                }
                else if (result == "5")
                {
                    Console.WriteLine();
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (4 - j > i)

                                Console.Write(" ");

                            else
                                Console.Write("X");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();

                }
                else if (result == "6")
                {
                    Console.WriteLine("  X  ");
                    Console.WriteLine(" XXX ");
                    Console.WriteLine("XXXXX");
                    Console.WriteLine("Easy gg");
                    Console.WriteLine();








                }
                else if (result == "7")

                {
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (j == i)

                                Console.Write(" ");

                            else
                                Console.Write("X");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                }
                else if (result == "8")
                {
                    Console.WriteLine();
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (4-j==i)

                                Console.Write(" ");

                            else
                                Console.Write("X");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                }
                else if (result == "9")
                {
                    for(int i= 0; i <5; i++)
                    {
                        for(int j = 0; j < 5; j++)
                        {
                            if (j == i || 4 - j == i)
                                Console.Write(" ");
                            else
                                Console.Write("X");
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("PLEASE ENTER A VALID ANSWER");
                }
            }
        }



    }
}

