using System;
using System.Linq;
using System.Collections.Generic;

namespace TradingCardGameKata
{
    internal class Deck
    {
        private static readonly List<int> ManaCosts = new List<int>
        {
            0,0,1,1,2,2,2,3,3,3,3,4,4,4,5,5,6,6,7,8
        };

        protected readonly Queue<Card> _cards;

        public int Count => _cards.Count;

        public Deck()
        {
            _cards = new Queue<Card>();
            var manaCostShuffled = ManaCosts.OrderBy(a => Guid.NewGuid());
            foreach (int manaCost in manaCostShuffled)
            {
                _cards.Enqueue(new Card(manaCost));
            }
        }

        public Card Draw()
        {
            return _cards.Dequeue();
        }

        public override bool Equals(object obj)
        {
            var deckObj = obj as Deck;
            if (deckObj == null)
            {
                return false;
            }
            if (deckObj.Count != Count)
            {
                return false;
            }
            if (deckObj._cards.Zip(_cards, (x, y) => !x.Equals(y)).Any(b => b))
            {
                return false;
            }
            return true;
        }
    }
}