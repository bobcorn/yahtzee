using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yahtzee.Presenter;

namespace Yahtzee.Model
{

    class Turn : ITurn
    {
        private PlayerTurn[] _playerTurns;
        private int _currentPlayerTurnIndex;
        private List<IPlayer> _players;

        public event TurnEventHandler TurnStarted;
        public event TurnEventHandler TurnEnded;
        public event PlayerTurnEventHandler PlayerTurnEnd;
        public event PlayerTurnEventHandler PlayerTurnStarted;

        public PlayerTurn CurrentPlayerTurn
        {
            get { return _playerTurns[_currentPlayerTurnIndex]; }
        }

        public IPlayer CurrentPlayer
        {
            get { return CurrentPlayerTurn.Player; }
        }

        public Turn(List<IPlayer> players)
        {
            _players = players;
            _playerTurns = new PlayerTurn[_players.Count];
            _currentPlayerTurnIndex = 0;
        }

        public void NewPlayerTurn()
        {
            var pt = new PlayerTurn(_players[_currentPlayerTurnIndex]);
            pt.TurnStarted += OnPlayerTurnStarted;
               pt.TurnEnded += OnPlayerTurnEnd;
               pt.FinishedRolls += OnPlayerFinishesRolls;
            _playerTurns[_currentPlayerTurnIndex] = pt;
            pt.Start();
        }

        public void Start()
        {
            TurnStarted?.Invoke(this, EventArgs.Empty);
            NewPlayerTurn();
        }

        public void End()
        {
            TurnEnded?.Invoke(this, EventArgs.Empty);
        }

        private void OnPlayerFinishesRolls(PlayerTurn sender, EventArgs e)
        {
            Console.WriteLine("Player " + sender.Player.Name + " finished rolls.");
        }

        private void OnPlayerTurnStarted(PlayerTurn sender, EventArgs e)
        {
            Console.WriteLine(sender.Player.Name + " started turn.");

            PlayerTurnStarted?.Invoke(sender, EventArgs.Empty);
        }

        private void OnPlayerTurnEnd(PlayerTurn sender, EventArgs e)
        {
            Console.WriteLine(sender.Player.Name + " ended turn.");

            PlayerTurnEnd?.Invoke(sender, e);

            if (++_currentPlayerTurnIndex == _players.Count)
                End();
            else
                NewPlayerTurn();
        }
    }
}
