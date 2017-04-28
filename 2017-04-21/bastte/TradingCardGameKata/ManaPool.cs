using System;
using System.Collections.Generic;
using System.Text;

namespace TradingCardGameKata
{
    public class ManaPool
    {
        public int Capacity { get; private set; }
        public int Count { get; private set; }

        public void Add()
        {
            Capacity++;
            Count++;
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
