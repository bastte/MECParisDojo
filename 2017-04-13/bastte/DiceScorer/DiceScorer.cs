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
            int count = dice.Count(x => x == 1);
                
            return count == 1 ? 100 : 0;
        }
    }
}
