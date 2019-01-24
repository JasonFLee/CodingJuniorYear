
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck mystack = new Deck();
                List<Card> discard = new List<Card>();
            List<Card> hand = new List<Card>();
            List<Card> hand2 = new List<Card>();
            int selection;
            do
            {
                Console.WriteLine("1) Shuffle");
                Console.WriteLine("2) Discard the top card in the deck");
                Console.WriteLine("3) Draw");
                Console.WriteLine("4) Print Deck");
                Console.WriteLine("5) Print Discard Pile");
                Console.WriteLine("6) Print Hand 1");
                Console.WriteLine("7) Print Hand 2");
                Console.WriteLine("8) Exit");
                Console.WriteLine("What do you want to do?");
                selection = int.Parse(Console.ReadLine());
                if (selection == 1)
                {
                    discard.Clear();
                    mystack.Shuffle();
                }
                if (selection == 2)
                {

                    discard.Add(mystack.discarded());
                }
                if (selection == 3)
                {
                    Console.WriteLine("Which hand do you want to put the card in? (1 or 2)");
                   int  handwhich = int.Parse(Console.ReadLine());
                    if(handwhich == 1) {
                        hand.Add(mystack.Draw());
                    }
                    if (handwhich == 2)
                    {
                        hand2.Add(mystack.Draw());
                    }


                   
                }
                if (selection == 4)
                {
                    mystack.PrintDeck();
                }
                if (selection == 5)
                {
                    Console.WriteLine("The discard pile: ");
                    foreach (Card d in discard)
                    {
                        d.Print();
                    }
                   
                }
                if (selection == 6)
                {
                    Console.WriteLine("Your hand: ");
                    foreach (Card h in hand)
                    {
                        h.Print();
                    }
                }
             
                if (selection == 7)
                {
                    Console.WriteLine("Your hand 2: ");
                    foreach (Card h in hand2)
                    {
                        h.Print();
                    }
                }
            } while (selection != 8);
        }
    }
}