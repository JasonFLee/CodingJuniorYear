﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSPLOTION
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your string");
           string given =  Console.ReadLine();
            for (int x =0; x < given.Length +1; x ++)
            {
                for (int y = 0; y < given.Length-(given.Length -x); y++)
                {
                    Console.Write(given[y]);
                   
                }
                
            }
            
            Console.ReadLine();
        }
    }
}
