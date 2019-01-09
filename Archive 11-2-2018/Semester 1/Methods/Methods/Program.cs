using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;

            do {
                Console.WriteLine("**************");
                Console.WriteLine("1. Five plus Six");
                Console.WriteLine("2. Eleven plus Thirteen");
                Console.WriteLine("3. Three plus Nine");
                Console.WriteLine("**************");
                input = int.Parse(Console.ReadLine());
                if (input == 1)
                {
                    FiveSix();

                }
                if (input == 2)
                {
                    ElevenThirteen();

                }
                if (input == 3)
                {
                    ThreeNine();


                }
             


        

            } while(true);
            }
        static void FiveSix()
        {
         Console.WriteLine("11");

        }
        static void ElevenThirteen()
        {
            Console.WriteLine("24");

        }
        static void ThreeNine()
        {
            Console.WriteLine("12");

        }
    }
}
