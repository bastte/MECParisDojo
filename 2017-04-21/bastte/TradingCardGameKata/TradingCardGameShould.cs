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
            Assert.Equal(17, player.CardDeck.Count);
        }

        [Fact]
        public void PlayerHasInitialHandOf3Cards()
        {
            var player = new Player();
            Assert.Equal(3, player.Hand.Count);
        }
    }
}
