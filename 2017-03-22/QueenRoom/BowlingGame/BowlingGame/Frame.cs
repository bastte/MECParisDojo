using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame
{
    public class Frame
    {
        private const int maxRolls = 2;
        private int _currentRoll = 0;
        public void Roll(uint pins)
        {
            _currentRoll++;
            if (pins > RemainingPins())
            {
                throw new ArgumentOutOfRangeException(nameof(pins));
            }

            if (_currentRoll==1)
            {
                Roll1 = pins;
            }
            else if (_currentRoll == 2)
            {
                Roll2 = pins;
            }
        }

        public uint Roll1 { get; private set; }
        public uint Roll2 { get; private set; }

        public bool CanRoll()
        {
            return _currentRoll < maxRolls && RemainingPins() > 0;
        }

        public bool IsSpare()
        {
            return false;
        }

        public bool IsStrike()
        {
            return false;
        }

        private uint RemainingPins()
        {
            return 10 - Roll1 - Roll2;
        }
    }
}
