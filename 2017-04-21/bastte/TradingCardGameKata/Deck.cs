using System.Collections.Generic;

namespace TradingCardGameKata
{
    internal class Deck
    {
        private readonly List<Card> _cards;

        public int Count => _cards.Count;

        public Deck()
        {
            _cards = new List<Card>();
            for (var i = 0; i < 20; i++)
            {
                _cards.Add(new Card());
            }
        }
    }
}