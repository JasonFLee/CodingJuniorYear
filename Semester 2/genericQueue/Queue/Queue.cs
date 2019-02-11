using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    //FINISH T
    class Queue<T> : IEmptyable, IPritnable, ICountable where T : IComparable  , IPrintable  
    {
        List<T> holder = new List<T>();
        public Queue() { }
        public void EnQueue(T val)
        {
            holder.Add(0);
        }

       



        //pop
        public T DeQueue()
        {
            if (holder.Count != 0)
            {
                T top = holder[0];
                holder.RemoveAt(0);
                return top;
            }
            return default(T);
        }
        //peek
        public T Peek()
        {
            T top2 = holder[0];


            return top2;
        }
        //print
        public void Print()
        {


            foreach( T t in holder)
            {
                t.Print();
            }


            //Console.WriteLine("The Queue: ");
            //foreach (object o in holder)
            //{
            //    Console.WriteLine(o);
            //}


            
            Console.WriteLine(" ");
        }
        public void share()
        {

            Console.WriteLine("Which number do you want to look up?");

            int lookup = int.Parse(Console.ReadLine());
            for(int v = 0; v < 10000; v ++)
            {
                if (lookup.CompareTo( holder[v]) == 0)
                {
                    Console.WriteLine(lookup+ " is in spot "+ v);
                    v = v + 10060;
                }
            }

                
            }

        public void Empty()
        {
            throw new NotImplementedException();
        }

        public int Count()
        {
            throw new NotImplementedException();
        }
    }
}

