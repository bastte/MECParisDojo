using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGameKata
{
    public class BowlingGame
    {
        private Frame currentFrame = new Frame();

        public void Roll(int pin)
        {
            currentFrame.Roll(pin);
        }

        public int Score()
        {
            return currentFrame.FrameScore();
        }

        public Frame CurrentFrame()
        {
            return currentFrame;
        }
    }
}
