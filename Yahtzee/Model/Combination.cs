using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee.Model
{
    abstract class Combination 
    {
        private Dictionary<IPlayer, int> _playerScores;
        private Dictionary<IPlayer, bool> _playerUsed;
        
        abstract public string Name
        {
            get;
        }
        public Combination(List<IPlayer> players)
        {
            _playerScores = new Dictionary<IPlayer, int>();
            _playerUsed = new Dictionary<IPlayer, bool>();

            foreach (IPlayer p in players)
            {
                _playerScores.Add(p, 0);
                _playerUsed.Add(p, false);
            }
        }

        public  int GetScoreForPlayer(IPlayer player)
        {
            return _playerScores[player];
        }

        public  bool UsedByPlayer(IPlayer player)
        {
            return _playerUsed[player];
        }



        

        public void ApplyCombinationForPlayer(IPlayer player, IDices dices)
        {
            int score = CalculateScore(dices);
            _playerScores[player] = score;
            _playerUsed[player] = true;
        }

        abstract public int CalculateScore(IDices dices);

       
    }
}
