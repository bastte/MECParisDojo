namespace TradingCardGameKata
{
    using System;
    using Xunit;

    public class TradingCardGameShould
    {
        [Fact]
        public void PlayerStartsWithNoManaSlots()
        {
            var player = new Player();
            Assert.Equal(0, player.ManaSlots);
        }
    }
}
