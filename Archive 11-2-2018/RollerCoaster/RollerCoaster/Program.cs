using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollerCoaster
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] coaster = new int[10];
            Random rand = new Random();

            int input = 0;
            do
            {
                Console.WriteLine("1. Available Seats");
                Console.WriteLine("2. Put in Available Seats");
                Console.WriteLine("3. List how many riders");
                Console.WriteLine("4 Exit");
                if(input == 1)
                {
                    Console.WriteLine(coaster[1]);
                    Console.WriteLine(coaster[2]);
                    Console.WriteLine(coaster[3]);
                    Console.WriteLine(coaster[4]);
                    Console.WriteLine(coaster[5]);
                    Console.WriteLine(coaster[6]);
                    Console.WriteLine(coaster[7]);

                    Console.WriteLine(coaster[8]);

            
                    Console.WriteLine(coaster[9]);

                }

            if(input == 2)
                {

                }





                input = int.Parse(Console.ReadLine());
            } while (input != 4);




        }
    }
}
