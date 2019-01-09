using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sickofquinetonsns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int seed = 2423;
            Random rand = new Random(seed);
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 10);

            }
            for(int p = 0; p < array.Length; p++)
            {
                Console.Write(array[p]);
            }
           
            Console.WriteLine();
            for (int p = 0; p < array.Length; p++)
            {
               for(int k = 0; k < array.Length; k++)
                {
                   
                    if(array[k] < array[p])
                    {
                        int temp = array[k];
                        array[k] = array[p];
                        array[p] = temp;

                    }
                }
            }



            for (int o = 0; o < array.Length; o++)
            {
                Console.Write(array[o]);
            }
            Console.ReadLine();







        }
    }
}
