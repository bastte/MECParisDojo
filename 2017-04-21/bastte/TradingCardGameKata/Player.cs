using System.Collections.Generic;

namespace TradingCardGameKata
{
    internal class Player
    {
        public int ManaSlots { get; }
        public int Health { get; }

        public Player()
        {
            ManaSlots = 0;
            Health = 30;
        }
    }
}