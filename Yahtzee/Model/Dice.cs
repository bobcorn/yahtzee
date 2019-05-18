using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee.Model
{
    class Dice
    {
        private int _value;
        private static Random _random = new Random();

        public int Value
        {
            get { return _value; }
        }

        public Dice(int value)
        {
            // Generates a starting value
            _value = value;
        }

        public void Roll()
        {
            _value = _random.Next(1, 7);
        }
    }
}
