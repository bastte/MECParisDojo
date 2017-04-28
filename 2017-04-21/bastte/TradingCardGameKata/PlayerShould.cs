namespace TradingCardGameKata
{
    using System;
    using System.Linq;
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

        [Fact]
        public void PlayerSlotsAreRefilledAtTheBeginningOfTheRound()
        {
            // All slots are full
            _player.OnRoundStarted();
            _player.OnRoundStarted();
            Assert.Equal(2, _player.ManaAvailable);

            // All Slots are empty
            _player.SpendMana(2);
            _player.OnRoundStarted();
            Assert.Equal(3, _player.ManaAvailable);

            // Some Slots are empty
            _player.SpendMana(1);
            _player.OnRoundStarted();
            Assert.Equal(4, _player.ManaAvailable);
        }

        [Fact]
        public void PlayerDrawsRandomCardFromHisDeck()
        {
            var previousCards = _player.CardDeck.ToList();
            var previousHand = _player.Hand.ToArray();

            _player.Draw();

            var deck = _player.CardDeck;
            var hand = _player.Hand;

            Assert.Equal(hand.Except(previousHand).First(), previousCards.Except(deck).First());
        }

        [Fact]
        public void PlayerLosesHealthWhenDeckIsEmpty()
        {
            _player.CardDeck.DrawAllCards();
            Assert.Equal(30, _player.Health);
            _player.Draw();
            Assert.Equal(29, _player.Health);
        }
    }
}
