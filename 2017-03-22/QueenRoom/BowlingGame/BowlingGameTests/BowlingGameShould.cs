using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingGameTests
{
    using BowlingGame;

    [TestClass]
    public class BowlingGameShould
    {
        [TestMethod]
        public void ComputeScoreOnTenthFrame()
        {
            var game = new Game();

            for (int i = 0; i < 20; i++)
            {
                game.Roll(1);
            }

            Assert.AreEqual(20, game.Score());
        }

        [TestMethod]
        public void AllowToRoll()
        {
            var frame = new Frame();

            Assert.IsTrue(frame.CanRoll());
            frame.Roll(2);
            Assert.AreEqual(2u, frame.Roll1);

            Assert.IsTrue(frame.CanRoll());
            frame.Roll(3);
            Assert.AreEqual(2u, frame.Roll1);
            Assert.AreEqual(3u, frame.Roll2);

            Assert.IsFalse(frame.CanRoll());
        }
    }
}
