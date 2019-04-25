using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program {


        static void Main(string[] args)
        {
            string answer;
            binarytree newtree = new binarytree();
            Random random = new Random();
            do
            {
                Console.WriteLine("1. insert");
                Console.WriteLine("2. search");
                Console.WriteLine("3. print");
                Console.WriteLine("4. make tree random");
                Console.WriteLine("5. remove");
                Console.WriteLine("6. print preorder");
                Console.WriteLine("7. print postorder");
                Console.WriteLine("8. print inorder");
                Console.WriteLine("type 'quit' to quit");

                answer = Console.ReadLine();
                if (answer == "4")
                {
                    for (int i = 0; i < 8; i++)
                    {
                        int randomNumber = random.Next(65, 91);
                        newtree.insert((char)randomNumber);
                    }


                }
                if (answer == "1")
                {
                    Console.WriteLine("what letter do you want to insert to your tree?");
                    char letter = char.Parse(Console.ReadLine());
                    newtree.insert(letter);
                }
                if (answer == "3")
                {
                    newtree.Print();
                }
                if (answer == "2")
                {
                    Console.WriteLine("what letter are you searching?");
                    char lettersearch = char.Parse(Console.ReadLine());
                   if( newtree.Search(lettersearch) == false)
                    {
                        Console.WriteLine("no, it does not have that letter");
                    }
                    if (newtree.Search(lettersearch) == true)
                    {
                        Console.WriteLine("yes, it has that letter");
                    }
                }
                if(answer == "5")
                {
                    Console.WriteLine("what letter do you want to insert to delete from your tree?");
                    char deleter = char.Parse(Console.ReadLine());
                    newtree.Remove(deleter);
                }
                if(answer == "6")
                {
                    newtree.PreOrderPrint();
                    Console.WriteLine("done.");
                }
                if (answer == "7")
                {
                    newtree.PostOrderPrint();
                    Console.WriteLine("done.");
                }
                if (answer == "8")
                { 
                    newtree.InOrderPrint(); 

                    Console.WriteLine("done.");
                }


            } while (answer != "quit");
           



        }

    }

    
        
   
    
}
