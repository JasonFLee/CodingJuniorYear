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
            Queue myqueue = new Queue();
            int selection;
            do
            {
                Console.WriteLine("1) EnQueue");
                Console.WriteLine("2) Peek");
                Console.WriteLine("3) DeQueue");
                Console.WriteLine("4) Print");
                Console.WriteLine("5) Search");
                Console.WriteLine("6) Exit");



                Console.WriteLine("What do you want to do?");
                selection = int.Parse(Console.ReadLine());
                if (selection == 1)
                {
                    Console.WriteLine("What number do you want to add to your queue?");
                    int pushadd = int.Parse(Console.ReadLine());
                    myqueue.EnQueue(pushadd);
                    Console.WriteLine("Done");

                }
                if (selection == 2)
                {
                    Console.WriteLine("The top value is a " + myqueue.Peek());
                }
                if (selection == 3)
                {

                    

                    int popval = myqueue.DeQueue();
                    
                    if(popval == -1)
                    {
                        Console.WriteLine("Can't, your queue is empty");
                    }
                    else { Console.WriteLine("The top value of the queue is a " + popval); }
                        
                    




                }
                if (selection == 4)
                {

                    myqueue.Print();

                }
                if (selection == 5)
                {

                    myqueue.share();
                }

            } while (selection != 6);






        }
    }
}