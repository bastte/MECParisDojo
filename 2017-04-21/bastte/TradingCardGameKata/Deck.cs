using System;
using System.Collections.Generic;

namespace TradingCardGameKata
{
    internal class Deck
    {
        private static readonly List<int> ManaCosts = new List<int>
        {
            0,0,1,1,2,2,2,3,3,3,3,4,4,4,5,5,6,6,7,8
        };

        private readonly Queue<Card> _cards;

        public int Count => _cards.Count;

        public Deck()
        {
            _cards = new Queue<Card>();
            foreach(int manaCost in ManaCosts)
            {
                _cards.Enqueue(new Card(manaCost));
            }
        }

        public Card Draw()
        {
            return _cards.Dequeue();
        }
    }
}