namespace ClassroomA
{
    public class Card2
    {
        public enum Suit
        {
            Hearts,
            Diamonds,
            Clubs,
            Spades,
            Joker
        }

        public enum Value
        {
            Two,
            Three ,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King,
            Ace,
            None
        }

        private Suit _suitOfCard;
        private Value _valueOfCard;

        public Card2(Suit suitOfCard, Value valueOfCard)
        {
            _suitOfCard = suitOfCard;
            _valueOfCard = valueOfCard;
        }

        public Suit SuitOfCard
        {
            get { return _suitOfCard; }
        }

        public Value ValueOfCard
        {
            get { return _valueOfCard; }
        }
    }
}