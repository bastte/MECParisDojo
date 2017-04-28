using System;
using System.Collections.Generic;
using System.Text;

namespace TradingCardGameKata
{
    public class ManaPool
    {
        private const int MaxCapacity = 10;
        public int Capacity { get; private set; }
        public int Count { get; private set; }

        public void Add()
        {
            if (Capacity < MaxCapacity)
            {
                Capacity++;
            }
        }

        public void Spend(int amount)
        {
            if (amount > Count)
            {
                throw new ArgumentException("Not enough mana available", nameof(amount));
            }

            Count -= amount;
        }

        public void Refill()
        {
            Count = Capacity;
        }
    }
}
