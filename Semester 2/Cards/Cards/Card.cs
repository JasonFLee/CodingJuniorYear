using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    class Card
    {
        string face;
        string suit;
        public Card(string suit, string face)
        {
            this.suit = suit;
            this.face = face;
        }
        public void Print()
        {
            //needs to print the cards specific face and suit
            Console.WriteLine(" ______________________");
            Console.WriteLine("|" + "The " + face + " of " + suit + "   |");
            Console.WriteLine(" ----------------------");
        }
    }
}
