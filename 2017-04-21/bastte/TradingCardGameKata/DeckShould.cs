using System;
using System.Collections.Generic;
using System.Linq;
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

        [Fact]
        public void InitializeWithFixedSetOfCards()
        {
            List<int> expectedValues = new List<int>
            {
                0,0,1,1,2,2,2,3,3,3,3,4,4,4,5,5,6,6,7,8
            };

            List<Card> cards = Enumerable.Range(1, 20).Select(i => _deck.Draw()).ToList();

            foreach(int expectedValue in expectedValues)
            {
                Card cardInDeck = cards.First(c => c.ManaCost == expectedValue);
                cards.Remove(cardInDeck);
            }

            Assert.Equal(0, cards.Count);
        }
    }
}
