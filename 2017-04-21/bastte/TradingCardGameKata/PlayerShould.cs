namespace TradingCardGameKata
{
    using System;
    using Xunit;

    public class PlayerShould
    {
        private readonly Player _player = new Player();

        [Fact]
        public void PlayerStartsWithNoManaSlots()
        {
            Assert.Equal(0, _player.ManaSlots);
        }

        [Fact]
        public void PlayerStarsWith30Health()
        {
            Assert.Equal(30, _player.Health);
        }

        [Fact]
        public void PlayerHasInitialDeckOf20Cards()
        {
            Assert.Equal(17, _player.CardDeck.Count);
        }

        [Fact]
        public void PlayerHasInitialHandOf3Cards()
        {
            Assert.Equal(3, _player.Hand.Count);
        }

        [Fact]
        public void PlayerReceivesOneManaSlotAtTheBeginningOfTheRound()
        {
            Assert.Equal(0, _player.ManaSlots);
            _player.OnRoundStarted();
            Assert.Equal(1, _player.ManaSlots);
        }
    }
}
