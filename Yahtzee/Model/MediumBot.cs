using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee.Model
{
    class MediumBot : IBot
    {
        private Random r;
        private String _name;
        public MediumBot(string name)
        {
            r = new Random();
            _name = name;
        }

        public string Name {
            get { return _name; }
        }

        public ICommand DoSomething(IGame game)
        {
            // Always first throw!
            if (game.CurrentPlayerTurn.RemainingRolls == 3)
                return new RollDicesCommand();

            if (game.CurrentPlayerTurn.RemainingRolls != 0)
            {
                if (r.Next(10) < 7) // 30% chance of keeping a dice
                    return new RollDicesCommand();
                else
                {
                    int idx = r.Next(5);

                    if (game.Dices.Kept[idx])
                        return new KeepDiceCommand(idx, false);
                    else
                        return new KeepDiceCommand(idx, true);
                }

            }
            else
                return new SelectCombinationCommand(DecideCombination(game));
        }

        private Combination DecideCombination(IGame game)
        {
            Combination result = null;

            foreach (Combination c in game.Scoreboard.Combinations)
            {
                if (!c.UsedByPlayer(game.CurrentPlayer))
                {
                    if (result == null)
                        result = c;
                    else if (result.CalculateScore(game.Dices) < c.CalculateScore(game.Dices))
                        result = c;
                }
            }

            return result;
        }
    }
}
