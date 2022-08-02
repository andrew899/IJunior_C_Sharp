using System;
using System.Collections.Generic;

namespace IJuniorHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            DeckOfCards deck = new DeckOfCards();

            Console.ReadLine();
        }
    }

    internal class DeckOfCards
    {
        private List<Card> _cards;

        public DeckOfCards()
        {
            for (int i = 14; i > 0; i--)
            {
                _cards.Add(new Card(i, "Spades"));
            }

            for (int i = 14; i > 0; i--)
            {
                _cards.Add(new Card(i, "Hearts"));
            }

            for (int i = 14; i > 0; i--)
            {
                _cards.Add(new Card(i, "Clubs"));
            }

            for (int i = 14; i > 0; i--)
            {
                _cards.Add(new Card(i, "Diamonds"));
            }
        }

        public void ShuffleDeck()
        {
            Random rng = new Random();
            int length = _cards.Count;

            while(length > 1)
            {
                length--;
                int k = rng.Next(length + 1);
                Card temp = _cards[k];
                _cards[k] = _cards[length];
                _cards[length] = temp;
            }
        }
    }

    internal class Card
    {
        public int cardValue { get; private set; }
        public string cardSuit { get; private set; }

        public Card(int cardValue, string cardSuit)
        {
            this.cardValue = cardValue;
            this.cardSuit = cardSuit;
        }
    }
}
