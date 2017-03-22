using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGameKata
{
    public class BowlingGame
    {
        private int score;
        
        public void Roll(int pin)
        {
            score += pin;
        }

        public int Score()
        {
            return score;
        }
    }
}
