using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee.Model
{
    class Dices : IDices
    {
        private Dice[] _dices;
        private bool[] _kept;

        public event EventHandler<RollEventArgs> DicesRolled;
        public event EventHandler<KeepEventArgs> DiceKept;

        public Dices()
        {
            _dices = new Dice[5];
            _kept = new bool[5];

            for (int i = 0; i < _dices.Length; i++)
                _dices[i] = new Dice(i + 1);

            ReleaseAll();
        }

        public bool[] Kept
        {
            get { return _kept; }
        }

        public void Keep(int index, bool keep)
        {
            if (index < 0 || index > 4)
                throw new ArgumentException("Invalid dice index: " + index);

            _kept[index] = keep;
            OnKept(index, new KeepEventArgs(index, GetValues()[index], keep));
        }

        public void Roll()
        {
            int[] values = new int[5];

            for (int i = 0; i < _dices.Length; i++)
                if (!_kept[i])
                {
                    _dices[i].Roll();
                    values[i] = _dices[i].Value;
                }
                    
                else
                    values[i] = -1;

            OnRoll(new RollEventArgs(values));       
        }

        public int[] GetValues()
        {
            int[] res = new int[5];

            for (int i = 0; i < _dices.Length; i++)
                res[i] = _dices[i].Value;

            return res;
        }

        public void ReleaseAll()
        {
            for (int i = 0; i < _kept.Length; i++)
            {
                _kept[i] = false;
                OnKept(i, new KeepEventArgs(i, GetValues()[i], false));
            }     
        }

        public bool AllKept()
        {
            int x = 0;

            for (int i = 0; i < _kept.Length; i++)
                if (_kept[i])
                    x++;

            return (x == 5) ? true : false;
        }

        private void OnRoll(RollEventArgs args)
        {
            if (DicesRolled != null)
                DicesRolled(this, args);
        }
        private void OnKept(int index, KeepEventArgs args)
        {
            if (DiceKept != null)
                DiceKept(index, args);
        }

    }
}
