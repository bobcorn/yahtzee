using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee.Model
{
    static class PlayerFactory
    {
        static public List<IPlayer> getInstance(int numBot, String user,String difficulty)
        {


            String[] _nomiBot = { "Bot1", "Bot2", "Bot3", "Bot4", "Bot5" };
            List<IPlayer> _players = new List<IPlayer>();
            _players.Add(new User(user));
            int diff = 0;
            switch (difficulty) {
                case "Easy": diff= 1;
                    break;
                case "Medium": diff = 2;
                    break;
                case "Hard": diff = 3;
                    break;
                default: diff = 1;
                    break;
            }
            for (int i = 0; i < numBot; i++)
                _players.Add(BotFactory.getInstance(_nomiBot[i],diff));
            return _players;

        }
    }
}
