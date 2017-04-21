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

        [Fact]
        public void PlayerStarsWith30Health()
        {
            var player = new Player();
            Assert.Equal(30, player.Health);
        }

        [Fact]
        public void PlayerHasInitialDeckOf20Cards()
        {
            var player = new Player();
            Assert.Equal(20, player.CardDeck.Count);
        }
    }
}
