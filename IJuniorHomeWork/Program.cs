using System;
using System.Collections.Generic;

namespace IJuniorHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            DeckOfCards deck = new DeckOfCards();

            bool isWorking = true;

            while (isWorking)
            {
                Console.WriteLine("1. Take one card from deck.");
                Console.WriteLine("2. Take few card from deck.");
                Console.WriteLine("3. Show cards in hand.");
                Console.WriteLine("4. Exit.");

                var userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        player.AddCard(deck);
                        break;

                    case "2":
                        player.AddCard(deck, "few");
                        break;

                    case "3":
                        player.PrintAllCards();
                        break;

                    case "4":
                        isWorking = false;
                        break;

                    default:
                        Console.WriteLine("Wrong input.");
                        break;
                }
            }
        }
    }

    internal class Player
    {
        private List<Card> _cardInHand = new List<Card>();
        
        public void AddCard(DeckOfCards deck, string amountOfCards = "one")
        {
            List<Card> cards;

            switch (amountOfCards)
            {
                case "one":
                    if (deck.TryGetCard(out cards))
                    {
                        _cardInHand.AddRange(cards);
                    }
                    break;

                default:
                    Console.Write("Enter amount of cards: ");
                    string userAmountOfCards = Console.ReadLine();

                    if (Int32.TryParse(userAmountOfCards, out int userAmount))
                    {
                        while (userAmount-- > 0)
                        {
                            if (deck.TryGetCard(out cards))
                            {
                                _cardInHand.AddRange(cards);
                            }
                        }
                    }
                    break;
            }
        }

        public void PrintAllCards()
        {
            foreach (Card card in _cardInHand)
            {
                switch (card.CardSuit)
                {
                    case "Hearts":
                    case "Diamiond":
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"{card.CardSuit, -8} : {card.CardValue}");
                        Console.ResetColor();
                        break;

                    default:
                        Console.WriteLine($"{card.CardSuit, -8} : {card.CardValue}");
                        break;
                }
            }
        }
    }

    internal class DeckOfCards
    {
        private List<Card> _cards = new List<Card>();

        public DeckOfCards()
        {
            AddCardsSuit("Spades");
            AddCardsSuit("Hearts");
            AddCardsSuit("Clubs");
            AddCardsSuit("Diamonds");

            ShuffleDeck();
        }

        private void AddCardsSuit(string suitName)
        {
            for (int i = 10; i > 0; i--)
            {
                _cards.Add(new Card(i.ToString(), suitName));
            }

            _cards.Add(new Card("Jack", suitName));
            _cards.Add(new Card("Queen", suitName));
            _cards.Add(new Card("King", suitName));
            _cards.Add(new Card("Ace", suitName));
        }

        public bool TryGetCard(out List<Card> cardOut, int amountOfCards = 1)
        {
            bool result = false;
            cardOut = new List<Card>();

            while (amountOfCards-- > 0)
            {
                if (_cards.Count > 0)
                {
                    cardOut.Add(_cards[0]);
                    _cards.RemoveAt(0);
                    result = true;
                }
            }

            return result;
        }

        public void ShuffleDeck()
        {
            Random random = new Random();

            for (int i = _cards.Count - 1; i >= 1; i--)
            {
                int j = random.Next(i + 1);

                Card temp = _cards[j];
                _cards[j] = _cards[i];
                _cards[i] = temp;
            }
        }

        public void PrintAllCards()
        {
            foreach (Card card in _cards)
            {
                switch (card.CardSuit)
                {
                    case "Hearts":
                    case "Diamonds":
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"{card.CardSuit, -8} : {card.CardValue}");
                        Console.ResetColor();
                        break;
                    default:
                        Console.WriteLine($"{card.CardSuit, -8} : {card.CardValue}");
                        break;
                }
            }
        }
    }

    internal class Card
    {
        public string CardValue { get; private set; }
        public string CardSuit { get; private set; }

        public Card(string cardValue, string cardSuit)
        {
            CardValue = cardValue;
            CardSuit = cardSuit;
        }
    }
}
