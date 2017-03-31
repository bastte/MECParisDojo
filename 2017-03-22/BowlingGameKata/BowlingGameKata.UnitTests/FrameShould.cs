using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGameKata.UnitTests
{
    [TestClass]
    public class FrameShould
    {
        [TestMethod]
        public void RollIncrementsScore()
        {
            Frame frame = new Frame();
            frame.Roll(5);
            Assert.AreEqual(5, frame.FrameScore());
        }

        [TestMethod]
        public void FrameIsStrike()
        {
            Frame frame = new Frame();
            frame.Roll(10);
            Assert.IsTrue(frame.IsStrike());
            Assert.IsFalse(frame.IsSpare());
        }

        [TestMethod]
        public void FrameIsSpare()
        {
            Frame frame = new Frame();
            frame.Roll(1);
            frame.Roll(9);
            Assert.IsTrue(frame.IsSpare());
            Assert.IsFalse(frame.IsStrike());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void FrameThrowsIfRolledTooManyTimes()
        {
            Frame frame = new Frame();
            frame.Roll(1);
            frame.Roll(2);
            frame.Roll(3);
        }

        [TestMethod]
        public void FrameIsFinished()
        {
            var frame = new Frame();
            frame.Roll(1);
            Assert.IsFalse(frame.IsFinished());
            frame.Roll(2);
            Assert.IsTrue(frame.IsFinished());
        }

        [TestMethod]
        public void FrameWithStrikeIsFinished()
        { 
            var frame = new Frame();
            frame.Roll(10);
            Assert.IsTrue(frame.IsFinished());
        }
    }
}
