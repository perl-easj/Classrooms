using System;
using System.Collections.Generic;

namespace ClassroomA
{
    public class CardDeck2
    {
        private List<Card2> _deck;

        public CardDeck2()
        {
            _deck = new List<Card2>();
        }

        public void Standard()
        {
            _deck.Clear();

            foreach (Card2.Suit suit in Enum.GetValues(typeof(Card2.Suit)))
            {
                foreach (Card2.Value val in Enum.GetValues(typeof(Card2.Value)))
                {
                    _deck.Add(new Card2(suit, val));
                }
            }
        }

        public void PrintDeck()
        {
            foreach (Card2 c in _deck)
            {
                Console.Write($"{c.ValueOfCard} of {c.SuitOfCard}");
                Tribute(c);
            }
        }

        #region Tribute
        private void Tribute(Card2 card)
        {
            Console.Write((card.SuitOfCard == Card2.Suit.Spades && card.ValueOfCard == Card2.Value.Ace) ? " (R.I.P Lemmy...)\n" : "\n");
        } 
        #endregion
    }
}