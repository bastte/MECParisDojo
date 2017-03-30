using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame
{
    public class Game
    {
        private List<Frame> frames;

        public Game()
        {
            frames = new List<Frame>();
        }

        public void Roll(int pins)
        {
            if (pins < 0 || pins > 10)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public int Score()
        {
            return 0;
        }
    }
}
