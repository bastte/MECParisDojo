using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGameKata
{
    public class BowlingGame
    {
        IList<Frame> frames = new List<Frame> { new Frame() };

        public int Round => frames.Count;

        public Frame CurrentFrame => frames.Last();

        public void Roll(int pin)
        {
            if (CurrentFrame.IsFinished)
                frames.Add(new Frame());

            CurrentFrame.Roll(pin);
        }

        public int Score()
        {
            return frames.Sum(f => f.FrameScore);
        }
    }
}
