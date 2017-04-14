namespace DiceScorer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DiceScorer
    {
        private readonly List<ScoreRule> _rules;

        public DiceScorer()
        {
            _rules = new List<ScoreRule>
            {
                new ThreePairsScoreRule(),
                new TripleAndMoreScoreRule(),
                new SingleDieScoreRule()
            };
        }

        public int Score(List<int> dice)
        {
            int score = 0;

            if (dice == null)
            {
                return score;
            }

            ValidateInput(dice);

            foreach (ScoreRule rule in _rules)
            {
                score += rule.Score(dice);
            }

            return score;
        }

        private void ValidateInput(List<int> dice)
        {
            if (dice.Any(x => x <= 0 || x > 6))
            {
                throw new ArgumentException("A dice only has 6 possible values");
            }

            if (dice.Count > 6)
            {
                throw new ArgumentException("This game accepts a maximum of 6 dice");
            }
        }
    }
}
