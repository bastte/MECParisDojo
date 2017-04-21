using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TradingCardGameKata
{
    public class DeckShould
    {
        private readonly Deck _deck = new Deck();

        [Fact]
        public void Contain20CardsInitially()
        {
            Assert.Equal(20, _deck.Count);
        }

        [Fact]
        public void CanDrawCards()
        {
            _deck.Draw();
            Assert.Equal(19, _deck.Count);
        }
    }
}
