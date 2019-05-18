using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee.Model
{
    class KeepEventArgs
    {
        private int _index;
        private bool _kept;
        private int _value;

        public int Index
        {
            get { return _index; }
        }

        public bool Kept
        {
            get { return _kept; }
        }

        public int Value
        {
            get { return _value; }
        }

        public KeepEventArgs(int index, int value, bool kept)
        {
            _index = index;
            _kept = kept;
            _value = value;
        }
    }
}
