using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Stack
    {
      
        List<int> holder = new List<int>();
        //public Stack()
        //{


        //}
        //push
        public void Push(int val)
        {
            holder.Add(val);
        }
        //pop
        public int Pop()
        {
            
            if ((holder.Count - 1) < 0)
            {
                Console.WriteLine("Cannot do that, the stack is empty");

            }
            else
            {
                holder.RemoveAt(holder.Count - 1);
            }

            
            
            
            
            int top = holder[holder.Count - 1];
            
     

            
           
       
            return top;
        }
        //peak
        public int Peek()
        {
            int top2 = holder[holder.Count - 1];
           
           
            return top2;
        }
        //print
        public void Print()
        {
            Console.WriteLine("The stack: ");
            foreach (object o in holder)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine(" ");
        }


    }
}
