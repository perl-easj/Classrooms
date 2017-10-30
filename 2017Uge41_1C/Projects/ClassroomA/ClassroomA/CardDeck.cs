using System;
using System.Collections.Generic;

namespace ClassroomA
{
    public class CardDeck
    {
        private List<Card> _deck;

        public CardDeck()
        {
            _deck = new List<Card>();
        }

        public void Standard()
        {
            _deck.Clear();

            List<string> suits = new List<string>{"Hearts", "Diamonds", "Clubs", "Spades"};
            foreach (string suit in suits)
            {
                for (int i = 1; i <= 13; i++)
                {
                    _deck.Add(new Card(i, suit));
                }
            }
        }

        public void PrintDeck()
        {
            foreach (Card c in _deck)
            {
                Console.WriteLine($"{c.Suit} #{c.Number}");
            }
        }
    }
}