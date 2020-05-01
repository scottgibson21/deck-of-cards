using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCardsApp
{
    public class Hand
    {
        public List<Card> Cards { get; }
        public int MaxCards { get; set; }

        public Hand()
        {
            Cards = new List<Card>();
        }

        public void AddCard(Card card)
        {
            if (Cards.Count >= MaxCards)
            {
                throw new Exception();
            }

            Cards.Add(card);
        }

        public void RemoveCard(Card card)
        {
            if (!Cards.Contains(card))
            {
                throw new Exception();
            }

            if (Cards.Count == 0)
            {
                throw new Exception();
            }

            Cards.Remove(card);
        }
    }
}
