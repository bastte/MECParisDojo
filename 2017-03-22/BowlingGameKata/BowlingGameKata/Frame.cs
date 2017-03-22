using System;
using System.Collections.Generic;
using System.Linq;

namespace BowlingGameKata
{
    public class Frame
    {
        List<int> RollScores = new List<int>();

        public void Roll(int pin)
        {
            if (pin < 0 || pin > 10)
                throw new ArgumentOutOfRangeException(nameof(pin));

            RollScores.Add(pin);
        }

        public int FrameScore()
        {
            return RollScores.Sum();
        }
    }
}