using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee.Model
{
    class RollDicesCommand : ICommand
    {
        public void Execute(IGame game)
        {
            game.RollDices();
        }
    }
}
