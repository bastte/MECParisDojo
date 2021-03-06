﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace TradingCardGameKata
{
    internal class Player
    {
        private ManaPool _pool;
        public int Health { get; private set; }
        public Deck CardDeck { get; }
        public List<Card> Hand { get; }

        public int ManaSlots => _pool.Capacity;
        public int ManaAvailable => _pool.Count;

        public Player()
        {
            _pool = new ManaPool();
            Health = 30;
            CardDeck = new Deck();
            Hand = new List<Card>();
            for (var i = 0; i < 3; i++)
            {
                Hand.Add(CardDeck.DrawForTests());
            }
        }

        public void OnRoundStarted()
        {
            _pool.Add();
            _pool.Refill();
        }

        internal void SpendMana(int amount)
        {
            _pool.Spend(amount);
        }

        internal void Draw()
        {
            if (CardDeck.TryDraw(out var card))
            {
                Hand.Add(card);
            }
            else
            {
                Health--;
            }
        }
    }
}