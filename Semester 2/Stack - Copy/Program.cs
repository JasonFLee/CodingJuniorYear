using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack mystack = new Stack();
            int selection;
            do
            {
                Console.WriteLine("1) Push");
                Console.WriteLine("2) Peek");
                Console.WriteLine("3) Pop");
                Console.WriteLine("4) Print");
                Console.WriteLine("5) Exit");
              

                Console.WriteLine("What do you want to do?");
                selection = int.Parse(Console.ReadLine());
                if (selection == 1)
                {
                    Console.WriteLine("What number do you want to add to your stack?");
                    int pushadd = int.Parse(Console.ReadLine());
                    mystack.Push(pushadd);
                    Console.WriteLine("Done");

                }
                if (selection == 2)
                {
                    Console.WriteLine("The top value is a " + mystack.Peek());
                }
                if (selection == 3)
                {
                  


                    int popval = mystack.Pop();
                    if(popval < 0)
                    {
                        Console.WriteLine("no");

                    }
                    else
                    {
                        Console.WriteLine("The top value of the stack is a " + popval);
                    }
                    



                }
                if (selection == 4)
                {
                   
                    mystack.Print();
                    
                }
               
            } while (selection != 5);
           
           

           

            
        }
    }
}
