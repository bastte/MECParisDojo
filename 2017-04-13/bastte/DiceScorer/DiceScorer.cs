namespace DiceScorer
{
    using System;
    using System.Collections.Generic;

    public class DiceScorer
    {
        private readonly List<ScoreRule> _rules;

        public DiceScorer()
        {
            _rules = new List<ScoreRule>
            {
                new PairScoreRule(),
                new TripleAndMoreScoreDice(),
                new SingleDieScoreRule()
            };
        }

        public int Score(List<int> dice)
        {
            int score = 0;

            foreach (ScoreRule rule in _rules)
            {
                score += rule.Score(dice);
            }

            return score;
        }
    }
}
