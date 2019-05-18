using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee.Model
{
    class KeepDiceCommand : ICommand
    {
        private int _index;
        private bool _kept;
        public void Execute(IGame game)
        {
            game.Dices.Keep(_index, _kept);
        }
        public KeepDiceCommand(int index, bool kept)
        {
            _index = index;
            _kept = kept;
        }
    }
}
