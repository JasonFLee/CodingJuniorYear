
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
            int selection;
            do
            {
                Console.WriteLine("1) Shuffle");
                Console.WriteLine("2) Discard the top card in the deck");
                Console.WriteLine("3) Draw");
                Console.WriteLine("4) Print Deck");
                Console.WriteLine("5) Print Discard Pile");
                Console.WriteLine("6) Print Hand");
                Console.WriteLine("7) Exit");
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
                    hand.Add(mystack.Draw());
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
            } while (selection != 7);
        }
    }
}