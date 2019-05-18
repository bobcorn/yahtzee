using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee.Model
{
    class RollEventArgs
    {
        private int[] _values;

        public int[] Values
        {
            get { return _values; }
        }

        public RollEventArgs(int[] values)
        {
            _values = values;
        }
    }
}
