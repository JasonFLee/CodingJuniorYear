using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int myInt;
            myInt = rand.Next();
            List<int> myIntList = new List<int>();
            Console.WriteLine(myInt);
            for (int i = 0; i < myIntList.Count; i++)
            {
                myIntList.Add(myInt);
            }
            foreach( int i in myIntList)
            {
                Console.WriteLine(myIntList[i]);
            }

            Console.WriteLine("ADD A NUMBER");
            int input = Convert.ToInt32(Console.ReadLine());


            myIntList.Add(input);

            foreach (int i in myIntList)
            {
                Console.WriteLine(myIntList);
            }
            Console.ReadLine();

        }
    }
}
