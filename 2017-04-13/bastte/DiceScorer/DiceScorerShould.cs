using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace DiceScorer
{
    [TestClass]
    public class DiceScorerShould
    {
        [TestMethod]
        public void CorrectlyScoreASingleDiceWithNoPoints()
        {
            var scorer = new DiceScorer();
            int score = scorer.Score(new List<int> { 3 });
            Assert.AreEqual(0, score);
        }

        [TestMethod]
        public void CorrectlyScoreASingleOneDice()
        {
            var scorer = new DiceScorer();
            int score = scorer.Score(new List<int> { 1 });
            Assert.AreEqual(100, score);
        }

        [TestMethod]
        public void CorrectlyScoreASingleFiveDice()
        {
            var scorer = new DiceScorer();
            int score = scorer.Score(new List<int> { 5 });
            Assert.AreEqual(50, score);
        }

        [TestMethod]
        public void CorrectlyScoreASingleOneAndASingleFiveDice()
        {
            var scorer = new DiceScorer();
            int score = scorer.Score(new List<int> { 1, 5 });
            Assert.AreEqual(150, score);
        }

        [TestMethod]
        public void CorrectlyScoreASampleSinglesSequence()
        {
            var scorer = new DiceScorer();
            int score = scorer.Score(new List<int> { 1, 2, 3, 5 });
            Assert.AreEqual(150, score);
        }

        [TestMethod]
        public void CorrectlyScoreATriple()
        {
            var scorer = new DiceScorer();
            int score = scorer.Score(new List<int> { 1, 1, 1 });
            Assert.AreEqual(1000, score);
        }
    }
}