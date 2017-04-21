using System;
using System.Collections.Generic;

namespace TradingCardGameKata
{
    internal class Deck
    {
        private readonly Queue<Card> _cards;

        public int Count => _cards.Count;

        public Deck()
        {
            _cards = new Queue<Card>();
            for (var i = 0; i < 20; i++)
            {
                _cards.Enqueue(new Card());
            }
        }

        public Card Draw()
        {
            return _cards.Dequeue();
        }
    }
}