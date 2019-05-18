using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee.Model
{
    static class TurnFactory
    {
       static public  ITurn getTurnInstance(List<IPlayer> players)
        {
            return new Turn( players);
        }
    }
}
