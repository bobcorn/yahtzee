using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee.Model
{
    delegate void PlayerTurnEventHandler(PlayerTurn sender, EventArgs e);

    class PlayerTurn
    {
        private int _remainingRolls;
        private IPlayer _player;
        public event PlayerTurnEventHandler TurnStarted;
        public event PlayerTurnEventHandler TurnEnded;
        public event PlayerTurnEventHandler FinishedRolls;

        public IPlayer Player
        {
            get { return _player;  }
        }
        public int RemainingRolls
        {
            get { return _remainingRolls; }
        }

        public PlayerTurn(IPlayer player)
        {
            _player = player;
            _remainingRolls = 3;
        }

        public void RollDices(IDices dices)
        {
            _remainingRolls--;
            dices.Roll();

            if (RemainingRolls < 1)
                FinishedRolls?.Invoke(this, EventArgs.Empty);
        }

        public void UseCombination(Scoreboard sb, Combination c, IDices dices)
        {
            sb.SetCombinationForPlayer(_player, c, dices);
            TurnEnded?.Invoke(this, EventArgs.Empty);
        }

        public void Start()
        {
            TurnStarted?.Invoke(this, EventArgs.Empty);
        }
    }
}
