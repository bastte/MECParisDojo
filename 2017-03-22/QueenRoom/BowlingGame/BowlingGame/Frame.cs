using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame
{
    public class Frame
    {
        public void Roll(uint pins)
        {
        }

        public uint Roll1 { get; private set; }
        public uint Roll2 { get; private set; }

        public bool CanRoll()
        {
        }

        public bool IsSpare()
        {
            return false;
        }

        public bool IsStrike()
        {
            return false;
        }
        }
    }
}
