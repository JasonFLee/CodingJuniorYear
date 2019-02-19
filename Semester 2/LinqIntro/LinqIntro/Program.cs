using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> l1 = new List<int>(){ 8,6,7,6,3,0,9};
            //List<int> l2 = new List<int>() { 3,2,2,8,0,4,7 };
            //List<int> l3 = new List<int>();


            //if the second list contains a number in the first list and is already not in the third list, put it in the third list
            //l3 = l2.Intersect(l1).ToList();

            //foreach(int i in l3)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();

            List<int> l1 = new List<int>() { 8, 6, 7, 5, 3, 0, 9 };
            List<int> l2 = new List<int>();
            //run through the list; if a number in the first list is greater than or equal to 5 then add to the second list that number

            // { 8,6,7,6,9}

            l2 = l1.Where(t => t >= 5 == true).ToList();
           
            foreach (int i in l2)
            {
                Console.Write(i + ", ");
            }
            Console.ReadLine();
        }
    }
}
