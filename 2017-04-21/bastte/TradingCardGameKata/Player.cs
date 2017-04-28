using System;
using System.Collections.Generic;
using System.Linq;

namespace TradingCardGameKata
{
    internal class Player
    {
        public int ManaSlots { get; private set; }
        public int Health { get; }
        public Deck CardDeck { get; }
        public List<Card> Hand { get; }

        public Player()
        {
            ManaSlots = 0;
            Health = 30;
            CardDeck = new Deck();
            Hand = new List<Card>();
            for (var i = 0; i < 3; i++)
            {
                Hand.Add(CardDeck.Draw());
            }
        }

        public void OnRoundStarted()
        {
            ManaSlots += 1;
        }
    }
}