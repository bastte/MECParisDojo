using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceScorer
{
    class DiceScorer
    {
        public int Score(List<int> dice)
        {
            int[] count = Enumerable.Range(1, 6).Select(value => dice.Count(x => x == value)).ToArray();

            int score = 0;
            if (count[1-1] == 1)
                score += 100;
            if (count[5-1] == 1)
                score += 50;
            return score;
        }
    }
}
