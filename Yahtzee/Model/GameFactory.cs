using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee.Model
{
    static class GameFactory
    {

        static public IGame getGameInstance(List<IPlayer> players)
        {
            return new Game(players);
        }
    }
}
