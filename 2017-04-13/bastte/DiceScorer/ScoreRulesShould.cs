namespace DiceScorer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Xunit;

    public class ScoreRulesShould
    {
        [Fact]
        public void SingleDieScoreRuleRemovesDie()
        {
            var rule = new SingleDieScoreRule();
            var dice = new List<int> { 1, 3, 5, 2 };

            rule.Score(dice);

            Assert.Equal(2, dice.Count);
            Assert.Equal(3, dice[0]);
            Assert.Equal(2, dice[1]);
        }

        [Fact]
        public void SingleDieScoreRuleCorrectlyScores()
        {
            var rule = new SingleDieScoreRule();
            var dice = new List<int> { 1, 3, 5, 2 };

            int score = rule.Score(dice);

            Assert.Equal(150, score);
        }

        [Fact]
        public void SingleDieScoreRuleShouldIgnoreNonSingleDice()
        {
            var rule = new SingleDieScoreRule();
            var dice = new List<int> { 1, 1, 5 };

            int score = rule.Score(dice);

            Assert.Equal(50, score);
            Assert.Equal(2, dice.Count);
            Assert.True(dice.All(x => x == 1));
        }

        [Fact]
        public void TripleAndMoreScoreRuleCorrectlyScoresFourDice()
        {
            var rule = new TripleAndMoreScoreRule();
            var dice = new List<int> { 1, 1, 1, 1, 5 };

            int score = rule.Score(dice);

            Assert.Equal(2000, score);
            Assert.Equal(1, dice.Count);
            Assert.Equal(5, dice[0]);
        }

        [Fact]
        public void TripleAndMoreScoreRuleCorrectlyScoresTwoTriples()
        {
            var rule = new TripleAndMoreScoreRule();
            var dice = new List<int> { 1, 3, 3, 1, 1, 3 };

            int score = rule.Score(dice);

            Assert.Equal(1300, score);
            Assert.Equal(0, dice.Count);
        }
    }
}
