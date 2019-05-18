using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee.Model
{
    class Statistics
    {
        private int _rank;
        private int _won;
        private int _lost;
        //public int Won
        //{
        //    get { return _won; }
        //}
        public int Won => _won;
        public int Lost => _lost;
        public int Rank
        {
            get { return _rank; }
        }
        public Statistics()
        {
            _won = 0;
            _lost = 0;
            _rank = 0;
        }
        public void Update(bool won)
        {
            if (won)
            {
                _won++;
            }
            else
            {
                _lost++;
            }
                _rank = _won / Lost;
        }

    }
}
