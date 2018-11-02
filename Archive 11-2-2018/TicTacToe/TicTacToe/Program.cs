using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TicTacToe
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string[,] multiDimentionalArray = new String[3, 3];
            DrawBoard




        }
        void DrawBoard (string[,] multiDimentionalArray)
        {
            Console.WriteLine(multiDimentionalArray[0,0] + " | " + multiDimentionalArray[0, 1] + " | " + multiDimentionalArray[0, 2]);
            Console.WriteLine("---------");
            Console.WriteLine(multiDimentionalArray[1, 0] + " | " + multiDimentionalArray[1, 1] + " | " + multiDimentionalArray[1, 2]);
            Console.WriteLine("---------");
            Console.WriteLine(multiDimentionalArray[2, 0] + " | " + multiDimentionalArray[2, 1] + " | " + multiDimentionalArray[2, 2]);

        }
         void ProcessTurn (string[,] multiDimentionalArray)
        {
            Console.WriteLine("x's go first, first to get 3 in a row wins");
            


            int x = 0;
            for (int i = 0; i < 9; i++)
            {
                String input = Console.ReadLine();
                x = x + 1;

                if (input == "1")
                {
                    if (x % 2 == 0)
                    {
                       multiDimentionalArray[0, 0] = "X";
                    }
                    else
                    {
                        multiDimentionalArray[0, 0] = "O";
                    }

                }
                if (input == "2")
                {
                    if (x % 2 == 0)
                    {
                        multiDimentionalArray[0, 1] = "X";
                    }
                    else
                    {
                        multiDimentionalArray[0, 1] = "O";
                    }

                }
                if (input == "3")
                {
                    if (x % 2 == 0)
                    {
                        multiDimentionalArray[0, 2] = "X";
                    }
                    else
                    {
                        multiDimentionalArray[0, 2] = "O";
                    }
                    //finish asinging mularray for bottom 2 rows

                }
                if (input == "4")
                {
                    if (x % 2 == 0)
                    {
                        multiDimentionalArray[1, 0] = "X";
                    }
                    else
                    {
                        multiDimentionalArray[1, 0] = "O";
                    }

                }
                if (input == "5")
                {
                    if (x % 2 == 0)
                    {
                        multiDimentionalArray[1, 1] = "X";
                    }
                    else
                    {
                        multiDimentionalArray[1, 1] = "O";
                    }

                }
                if (input == "6")
                {
                    if (x % 2 == 0)
                    {
                        multiDimentionalArray[1, 2] = "X";
                    }
                    else
                    {
                        multiDimentionalArray[1, 2] = "O";
                    }

                }
                if (input == "7")
                {
                    if (x % 2 == 0)
                    {
                        multiDimentionalArray[2, 0] = "X";
                    }
                    else
                    {
                        multiDimentionalArray[2, 0] = "O";
                    }

                }
                if (input == "8")
                {
                    if (x % 2 == 0)
                    {
                        multiDimentionalArray[2, 1] = "X";
                    }
                    else
                    {
                        multiDimentionalArray[2, 1] = "O";
                    }

                }
                if (input == "9                                                                                                                 ")
                {
                    if (x % 2 == 0)
                    {
                        multiDimentionalArray[2, 2] = "X";
                    }
                    else
                    {
                        multiDimentionalArray[2, 2] = "O";
                    }

                }

            
            }
           
        }
        
    }
}
