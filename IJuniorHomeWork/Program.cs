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
                        player.AddCards(deck);
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
        private List<Card> _cardsInHand = new List<Card>();
        
        public void AddCard(DeckOfCards deck)
        {
            if (deck.TryGetCard(out Card card))
            {
                _cardsInHand.Add(card);
            }
        }

        public void AddCards(DeckOfCards deck)
        {
            Console.Write("Enter amount of cards: ");
            string userAmountOfCards = Console.ReadLine();

            if (Int32.TryParse(userAmountOfCards, out int userAmount))
            {
                if (userAmount > deck.cardsInDeck)
                {
                    Console.WriteLine($"Deck has only {deck.cardsInDeck} cards.");
                    userAmount = deck.cardsInDeck;
                }
                for (int i = 0; i < userAmount; i++)
                {
                    AddCard(deck);
                }
            }
            else
            {
                Console.WriteLine("Wrong input.Must be number.");
            }
        }

        public void PrintAllCards()
        {
            foreach (Card card in _cardsInHand)
            {
                if (card.Suit == "Diamonds" || card.Suit == "Hearts")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }

                Console.WriteLine($"{card.Suit,-8} : {card.Value}");
                Console.ResetColor();
            }
        }
    }

    internal class DeckOfCards
    {
        private List<Card> _cards = new List<Card>();

        public int cardsInDeck => _cards.Count;

        public DeckOfCards()
        {
            List<string> cardNames = new List<string> { "Jack", "Queen", "King", "Ace" };
            List<string> cardSuits = new List<string> { "Diamonds", "Hearts", "Spades", "Clubs" };

            foreach (string cardSuit in cardSuits)
            {
                AddCardsSuit(cardSuit, cardNames);
            }

            ShuffleCards();
        }

        private void AddCardsSuit(string suitName, List<string> cardNames)
        {
            for (int i = 10; i > 0; i--)
            {
                _cards.Add(new Card(i.ToString(), suitName));
            }

            foreach (string cardName in cardNames)
            {
                _cards.Add(new Card(cardName, suitName));
            }
        }

        public bool TryGetCard(out Card cardOut)
        {
            bool result = false;
            cardOut = null;

            if (_cards.Count > 0)
            {
                cardOut = _cards[0];
                _cards.Remove(_cards[0]);
                result = true;
            }

            return result;
        }

        public void ShuffleCards()
        {
            Random random = new Random();

            for (int i = _cards.Count - 1; i >= 1; i--)
            {
                int randomMax = i + 1;
                int j = random.Next(randomMax);

                Card temp = _cards[j];
                _cards[j] = _cards[i];
                _cards[i] = temp;
            }
        }

        public void PrintAllCards()
        {
            foreach (Card card in _cards)
            {
                if(card.Suit == "Diamonds" || card.Suit == "Hearts")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }

                Console.WriteLine($"{card.Suit, -8} : {card.Value}");
                Console.ResetColor();
            }
        }
    }

    internal class Card
    {
        public string Value { get; private set; }
        public string Suit { get; private set; }

        public Card(string cardValue, string cardSuit)
        {
            Value = cardValue;
            Suit = cardSuit;
        }
    }
}
