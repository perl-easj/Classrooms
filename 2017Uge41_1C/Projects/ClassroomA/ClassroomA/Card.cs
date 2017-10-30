using System;

namespace ClassroomA
{
    public class Card
    {
        private int _number;
        private string _suit;

        public Card(int number, string suit)
        {
            if (number < 1 || number > 13)
            {
                // ERROR HANDLING
            }
            _number = number;
            _suit = suit;
        }


        public string Suit
        {
            get { return _suit; }
        }

        public int Number
        {
            get { return _number; }
            
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{_suit} - {_number}");
        }
    }
}