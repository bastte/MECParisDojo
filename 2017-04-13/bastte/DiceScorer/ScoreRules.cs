﻿namespace DiceScorer
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
        public int Score(List<int> dice)
        {
            int score = 0;

            int count1 = dice.Count(x => x == 1);
            int count5 = dice.Count(x => x == 5);

            if (count1 == 1)
            {
                score += 100;
                dice.Remove(1);
            }

            if (count5 == 1)
            {
                score += 50;
                dice.Remove(5);
            }

            return score;
        }
    }

    public class TripleAndMoreScoreDice : ScoreRule
    {
        public int Score(List<int> dice)
        {
            int score = 0;
            int count1 = dice.Count(x => x == 1);

            if (count1 >= 3)
            {
                score += 1000 << (count1 - 3);
                while (count1-- != 0)
                {
                    dice.Remove(1);
                }
            }

            for (int i = 2; i <= 6; ++i)
            {
                int count = dice.Count(x => x == i);
                if (count >= 3)
                {
                    score += (100 * i) << (count - 3);

                    while (count-- != 0)
                    {
                        dice.Remove(i);
                    }
                }
            }

            return score;
        }
    }

    public class PairScoreRule : ScoreRule
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
