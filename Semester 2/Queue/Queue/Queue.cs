using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Queue
    {
        List<int> holder = new List<int>();
        public void EnQueue(int val)
        {
            holder.Add(val);
        }
        //pop
        public int DeQueue()
        {
            if (holder.Count != 0)
            {
                int top = holder[0];
                holder.RemoveAt(0);
                return top;
            }
            return -1;
        }
        //peek
        public int Peek()
        {
            int top2 = holder[0];


            return top2;
        }
        //print
        public void Print()
        {
            Console.WriteLine("The Queue: ");
            foreach (object o in holder)
            {
                Console.WriteLine(o);
            }


            
            Console.WriteLine(" ");
        }
        public void share()
        {

            Console.WriteLine("Which number do you want to look up?");

            int lookup = int.Parse(Console.ReadLine());
            for(int v = 0; v < 10000; v ++)
            {
                if (lookup == holder[v])
                {
                    Console.WriteLine(lookup+ " is in spot "+ v);
                    v = v + 10060;
                }
            }

                
            }




        
    }
}

