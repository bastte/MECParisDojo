using System.Collections.Generic;
using System.Linq;

namespace TradingCardGameKata
{
    internal class Player
    {
        public int ManaSlots { get; }
        public int Health { get; }
        public List<Card> CardDeck { get; }
        public List<Card> Hand { get; }

        public Player()
        {
            ManaSlots = 0;
            Health = 30;
            CardDeck = new List<Card>();
            for(var i = 0; i < 20; i++)
            {
                CardDeck.Add(new Card());
            }
            Hand = CardDeck.Take(3).ToList();
            CardDeck = CardDeck.Skip(3).ToList();
        }
    }
}