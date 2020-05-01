using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCardsApp
{
    public class DeckOfCards
    {
        private const int _numberOfCards = 52;

        private Random _randomizer => new Random();
        public List<Card> Cards { get; private set; }
        public List<Card> DiscardPile { get; private set; }

        public DeckOfCards()
        {
            Cards = new List<Card>();
            DiscardPile = new List<Card>();
            OrderDeck();
        }

        public void OrderDeck()
        {
            for (int suite = 0; suite < 4; suite++)
            {
                for (int cardValue = 1; cardValue < 14; cardValue++)
                {
                    Cards.Add(new Card { Suite = (ESuite)suite, Value = cardValue });
                }
            }
        }

        public void ShuffleCards()
        {
            Console.WriteLine("Shuffling Cards...");

            for (int i = 0; i < 100; i++)
            {
                var randomCard1 = _randomizer.Next(0, Cards.Count);
                var randomCard2 = _randomizer.Next(0, Cards.Count);
                var tempHolder = Cards[randomCard1];
                Cards[randomCard1] = Cards[randomCard2];
                Cards[randomCard2] = tempHolder;
            }

            Console.WriteLine("Shuffling Complete!");
        }

        public void PrintCards()
        {
            foreach (Card card in Cards)
            {
                Console.WriteLine($"{card.ValueToString()} of {card.Suite.ToString()}'s");
            }
        }

        public void DealFiveCards()
        {
            Console.WriteLine("Dealing...");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{Cards[0].ValueToString()} of {Cards[0].Suite.ToString()}'s");
                DiscardPile.Add(Cards[0]);
                Cards.RemoveAt(0);
            }
        }
    }
}
