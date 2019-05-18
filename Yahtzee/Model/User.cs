using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee.Model
{
    class User : IPlayer
    {
        private Statistics _statistics = new Statistics();
        private String _name;

        public User(string name) 
        {
            _name = name;
        }

        public String Name
        {
            get {  return  _name;  }
        }

        public void GameCompleted( bool won)
        {
            _statistics.Update(won);
        }
        public int Rank()
        {
            return _statistics.Rank;
        }
    }
}
