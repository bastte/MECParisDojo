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
    }
}
