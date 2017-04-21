using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TradingCardGameKata
{
    public class CardShould
    {
        [Fact]
        public void HaveManaCost()
        {
            Card card = new Card(0);
            Assert.Equal(0, card.ManaCost);
        }
    }
}
