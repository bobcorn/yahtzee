using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Yahtzee.Model
{
    class SelectCombinationCommand : ICommand
    {
        private Combination _combination;
        public void Execute(IGame game)
        {
            game.UseCombination(_combination);
        }
        public SelectCombinationCommand(Combination combination)
        {
            _combination = combination;
        }
    }
}



