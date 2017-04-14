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


    }
}
