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

        public bool IsSpare()
        {
            return RollScores.Count() >= 2
                && RollScores[0] < 10
                && RollScores[0] + RollScores[1] == 10;
        }

        public bool IsStrike()
        {
            return RollScores.Count() >= 1
             && RollScores[0] == 10;
        }
    }
}