using System;
using System.Collections.Generic;

namespace IJuniorHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            DeckOfCards deck = new DeckOfCards();
        }
    }

    internal class DeckOfCards
    {
        private List<Card> _cards;

        public DeckOfCards()
        {
        }
    }

    internal class Card
    {
        public string CardName { get; private set; }
        public string CardSuit { get; private set; }
    }

    public enum CardsName
    {

    }

    public enum CardsSiut
    {

    }
}
