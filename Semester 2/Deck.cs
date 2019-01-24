using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    class Deck
    {
        List<Card> deck = new List<Card>();

        List<Card> discard = new List<Card>();

        public Deck()
        {
            deck.Clear();

            deck.Add(new Card("Clubs", "Ace"));
            deck.Add(new Card("Spades", "Ace"));
            deck.Add(new Card("Diamonds", "Ace"));
            deck.Add(new Card("Hearts", "Ace"));

            deck.Add(new Card("Clubs", "Two"));
            deck.Add(new Card("Spades", "Two"));
            deck.Add(new Card("Diamonds", "Two"));
            deck.Add(new Card("Hearts", "Two"));

            deck.Add(new Card("Clubs", "Three"));
            deck.Add(new Card("Spades", "Three"));
            deck.Add(new Card("Diamonds", "Three"));
            deck.Add(new Card("Hearts", "Three"));

            deck.Add(new Card("Clubs", "Four"));
            deck.Add(new Card("Spades", "Four"));
            deck.Add(new Card("Diamonds", "Four"));
            deck.Add(new Card("Hearts", "Four"));

            deck.Add(new Card("Clubs", "Five"));
            deck.Add(new Card("Spades", "Five"));
            deck.Add(new Card("Diamonds", "Five"));
            deck.Add(new Card("Hearts", "Five"));

            deck.Add(new Card("Club", "Six"));
            deck.Add(new Card("Spade", "Six"));
            deck.Add(new Card("Diamond", "Six"));
            deck.Add(new Card("Heart", "Six"));

            deck.Add(new Card("Clubs", "Seven"));
            deck.Add(new Card("Spades", "Seven"));
            deck.Add(new Card("Diamonds", "Seven"));
            deck.Add(new Card("Hearts", "Seven"));

            deck.Add(new Card("Clubs", "Eight"));
            deck.Add(new Card("Spades", "Eight"));
            deck.Add(new Card("Diamonds", "Eight"));
            deck.Add(new Card("Hearts", "Eight"));

            deck.Add(new Card("Clubs", "Nine"));
            deck.Add(new Card("Spades", "Nine"));
            deck.Add(new Card("Diamonds", "Nine"));
            deck.Add(new Card("Hearts", "Nine"));

            deck.Add(new Card("Clubs", "Ten"));
            deck.Add(new Card("Spades", "Ten"));
            deck.Add(new Card("Diamonds", "Ten"));
            deck.Add(new Card("Hearts", "Ten"));

            deck.Add(new Card("Clubs", "Jack"));
            deck.Add(new Card("Spades", "Jack"));
            deck.Add(new Card("Diamonds", "Jack"));
            deck.Add(new Card("Hearts", "Jack"));

            deck.Add(new Card("Clubs", "Queen"));
            deck.Add(new Card("Spades", "Queen"));
            deck.Add(new Card("Diamonds", "Queen"));
            deck.Add(new Card("Hearts", "Queen"));

            deck.Add(new Card("Clubs", "King"));
            deck.Add(new Card("Spades", "King"));
            deck.Add(new Card("Diamonds", "King"));
            deck.Add(new Card("Hearts", "King"));

        }

        public void Shuffle()
        {
            deck.Clear();
            discard.Clear();

            deck.Add(new Card("Clubs", "Ace"));
            deck.Add(new Card("Spades", "Ace"));
            deck.Add(new Card("Diamonds", "Ace"));
            deck.Add(new Card("Hearts", "Ace"));

            deck.Add(new Card("Clubs", "Two"));
            deck.Add(new Card("Spades", "Two"));
            deck.Add(new Card("Diamonds", "Two"));
            deck.Add(new Card("Hearts", "Two"));

            deck.Add(new Card("Clubs", "Three"));
            deck.Add(new Card("Spades", "Three"));
            deck.Add(new Card("Diamonds", "Three"));
            deck.Add(new Card("Hearts", "Three"));

            deck.Add(new Card("Clubs", "Four"));
            deck.Add(new Card("Spades", "Four"));
            deck.Add(new Card("Diamonds", "Four"));
            deck.Add(new Card("Hearts", "Four"));

            deck.Add(new Card("Clubs", "Five"));
            deck.Add(new Card("Spades", "Five"));
            deck.Add(new Card("Diamonds", "Five"));
            deck.Add(new Card("Hearts", "Five"));

            deck.Add(new Card("Club", "Six"));
            deck.Add(new Card("Spade", "Six"));
            deck.Add(new Card("Diamond", "Six"));
            deck.Add(new Card("Heart", "Six"));

            deck.Add(new Card("Clubs", "Seven"));
            deck.Add(new Card("Spades", "Seven"));
            deck.Add(new Card("Diamonds", "Seven"));
            deck.Add(new Card("Hearts", "Seven"));

            deck.Add(new Card("Clubs", "Eight"));
            deck.Add(new Card("Spades", "Eight"));
            deck.Add(new Card("Diamonds", "Eight"));
            deck.Add(new Card("Hearts", "Eight"));

            deck.Add(new Card("Clubs", "Nine"));
            deck.Add(new Card("Spades", "Nine"));
            deck.Add(new Card("Diamonds", "Nine"));
            deck.Add(new Card("Hearts", "Nine"));

            deck.Add(new Card("Clubs", "Ten"));
            deck.Add(new Card("Spades", "Ten"));
            deck.Add(new Card("Diamonds", "Ten"));
            deck.Add(new Card("Hearts", "Ten"));

            deck.Add(new Card("Clubs", "Jack"));
            deck.Add(new Card("Spades", "Jack"));
            deck.Add(new Card("Diamonds", "Jack"));
            deck.Add(new Card("Hearts", "Jack"));

            deck.Add(new Card("Clubs", "Queen"));
            deck.Add(new Card("Spades", "Queen"));
            deck.Add(new Card("Diamonds", "Queen"));
            deck.Add(new Card("Hearts", "Queen"));

            deck.Add(new Card("Clubs", "King"));
            deck.Add(new Card("Spades", "King"));
            deck.Add(new Card("Diamonds", "King"));
            deck.Add(new Card("Hearts", "King"));
            deck = deck.OrderBy(a => Guid.NewGuid()).ToList();
        }
        public Card Draw()
        {
            if ((deck.Count - 1) < 0)
            {
                Console.WriteLine("Cannot do that, the stack is empty");
            }
            Card temp = deck[deck.Count - 1];
            deck.RemoveAt(deck.Count - 1);
            return temp;
        }
        public void PrintDeck()
        {
            Console.WriteLine("The deck: ");
            foreach (Card c in deck)
            {
                c.Print();
            }
        }
        public Card discarded()
        {
            if ((deck.Count - 1) < 0)
            {
                Console.WriteLine("Cannot do that, the stack is empty");
            }
            Card disCard = deck[deck.Count - 1];
            deck.RemoveAt(deck.Count - 1);
            return disCard;
        }       
      
    }
}