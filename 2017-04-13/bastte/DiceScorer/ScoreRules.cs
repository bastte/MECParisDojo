namespace DiceScorer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    interface ScoreRule
    {
        int Score(List<int> dice);
    }

    public class SingleDieScoreRule : ScoreRule
    {
        private static readonly Dictionary<int, int> _singleDieScore = new Dictionary<int, int>
        {
            { 1, 100 },
            { 5, 50 }
        };

        public int Score(List<int> dice)
        {
            int score = 0;

            foreach (var dieThatScores in _singleDieScore)
            {
                int count = dice.Count(x => x == dieThatScores.Key);
                if (count == 1)
                {
                    score += dieThatScores.Value;
                    dice.Remove(dieThatScores.Key);
                }
            }

            return score;
        }
    }

    public class TripleAndMoreScoreRule : ScoreRule
    {
        private static readonly Dictionary<int, int> _tripleDieScore = new Dictionary<int, int>
        {
            { 1, 1000 },
            { 2, 200 },
            { 3, 300 },
            { 4, 400 },
            { 5, 500 },
            { 6, 600 },
        };

        public int Score(List<int> dice)
        {
            int score = 0;

            foreach (var dieThatScores in _tripleDieScore)
            {
                int count = dice.Count(x => x == dieThatScores.Key);
                if (count >= 3)
                {
                    score += dieThatScores.Value << (count - 3);
                    while (count-- != 0)
                    {
                        dice.Remove(dieThatScores.Key);
                    }
                }
            }

            return score;
        }
    }

    public class ThreePairsScoreRule : ScoreRule
    {
        public int Score(List<int> dice)
        {
            if (dice.Count == 6 && dice.GroupBy(value => value).All(g => g.Count() == 2))
            {
                dice.Clear();
                return 800;
            }

            return 0;
        }
    }
}
