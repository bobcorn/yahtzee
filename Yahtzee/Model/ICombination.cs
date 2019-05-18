using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee.Model
{
    interface ICombination
    {
        string Name { get; }
        int GetScoreForPlayer(Player player);
        bool UsedByPlayer(Player player);
        int CalculateScore(Dices dices);
        void ApplyCombinationForPlayer(Player player, Dices dices);
    }
}
