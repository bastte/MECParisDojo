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
            if (pin < 0 || pin > 10)
                throw new ArgumentOutOfRangeException(nameof(pin));

            score += pin;
        }

        public int Score()
        {
            return score;
        }
    }
}
