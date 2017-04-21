using System.Collections.Generic;

namespace TradingCardGameKata
{
    internal class Player
    {
        public int ManaSlots { get; }
        public int Health { get; }
        public List<Card> CardDeck { get;  }

        public Player()
        {
            ManaSlots = 0;
            Health = 30;
            CardDeck = new List<Card>();
            for(var i = 0; i < 20; i++)
            {
                CardDeck.Add(new Card());
            }
        }
    }
}