using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2dArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[10][];
            for(int i = 0; i < jaggedArray.GetLength(0); i++)
            {
                jaggedArray[i] = new int[i + 1];
                for(int j = 0; j < jaggedArray[i].Length; j++)
                {
                    jaggedArray[i][j] = i * j;
                }

            }
            Print2DJaggedarray(jaggedArray);



        }
        static void Print2DJaggedarray(int [] []  jaggedArray)
        {

            for (int b = 0; b < jaggedArray.GetLength(0); b++)
            {
                for (int o = 0; o < jaggedArray[b].Length; o++)
                {
                    if (b < 10)
                    {
                        Console.Write(" |");
                    }
                    if (b > 10)
                    {
                        Console.Write("|");
                    }

                    Console.Write(jaggedArray[b] [o]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
        //    static void Main(string[] args)
        //    {
        //        int[,] multiDimentionalArray = new int[10, 5];
        //        for(int i = 0; i< multiDimentionalArray.GetLength(0); i++)
        //        {ye
        //            for(int j = 0; j < multiDimentionalArray.GetLength(1); j++)
        //            {
        //                multiDimentionalArray[i, j] = i * j;
        //            }
        //        }
        //        Print2DArray(multiDimentionalArray);
        //        Console.ReadLine();
        //    }
        //    static void Print2DArray(int[,] multiDimentionalArray)
        //    {
        //      for(int b = 0; b < multiDimentionalArray.GetLength(0); b++)
        //        {
        //            for(int o = 0; o < multiDimentionalArray.GetLength(1); o++)
        //            {
        //                if(b < 10)
        //                {
        //                    Console.Write(" |");
        //                }
        //                if (b > 10)
        //                {
        //                    Console.Write("|");
        //                }

        //                Console.Write(multiDimentionalArray[b,o]);
        //            }
        //            Console.WriteLine();
        //        }
        //    }

        //}
        //}
    }
