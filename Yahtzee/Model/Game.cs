using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yahtzee.Presenter;

namespace Yahtzee.Model
{
    class Game : IGame
    {
        private List<IPlayer> _players;
        private ITurn[] _turns;
        private int _currentTurn;
        private IDices _dices;
        private Scoreboard _scoreboard;

        private const int TURNS = 13; 

        public event EventHandler OnGameStart;
        public event EventHandler OnGameEnd;
        //public event EventHandler OnTurnStart;
        //public event EventHandler OnTurnEnd;
        public event PlayerTurnEventHandler PlayerTurnEnd;
        public event PlayerTurnEventHandler PlayerTurnStarted;

        public IPlayer CurrentPlayer
        {
             get { return CurrentPlayerTurn.Player; } 
        }
        public List<IPlayer> Players
        {
            get { return _players; }
        }
        public IDices Dices
        {
            get { return _dices; }
        }

        public Scoreboard Scoreboard
        {
            get { return _scoreboard; }
        }

        public ITurn CurrentTurn
        {
            get { return _turns[_currentTurn]; }
        }

        public PlayerTurn CurrentPlayerTurn
        {
            get { return _turns[_currentTurn].CurrentPlayerTurn; }
        }

        public Game(List<IPlayer> players)
        {
            // Do stuff
            _players = players;
            _dices = DicesFactory.getIDicesInstance();
            _currentTurn = 0;
            _turns = new ITurn[TURNS];
            _scoreboard = new Scoreboard(players);

            NewTurn();
            OnStart();
        }

        public void RollDices()
        {
            CurrentPlayerTurn.RollDices(_dices);
        }

        public void UseCombination(Combination c)
        {
            CurrentPlayerTurn.UseCombination(_scoreboard, c, _dices);
        }

        public void NewTurn()
        {
            _turns[_currentTurn] = TurnFactory.getTurnInstance(Players);
            _turns[_currentTurn].TurnStarted += OnTurnStarted;
            _turns[_currentTurn].TurnEnded +=OnTurnEnded;
            _turns[_currentTurn].PlayerTurnStarted += OnPlayerTurnStarted;
            _turns[_currentTurn].PlayerTurnEnd +=OnPlayerTurnEnded;
            _turns[_currentTurn].Start();
        }

        private void OnPlayerTurnStarted(PlayerTurn sender, EventArgs e)
        {
            if (PlayerTurnStarted != null)
                PlayerTurnStarted(sender, e);
        }

        private void OnPlayerTurnEnded(PlayerTurn sender, EventArgs e)
        {
            if (PlayerTurnEnd != null)
                PlayerTurnEnd(sender, e);
        }

        private void OnTurnEnded(object sender, EventArgs e)
        {
            Console.WriteLine("Turn " + _currentTurn + " ended.");

            _currentTurn++;

            if (_currentTurn == TURNS)
            {
                OnEnd();
            }
            else
            {
                NewTurn();
            }
        }

        private void OnStart()
        {
            if (OnGameStart != null)
                OnGameStart(this, EventArgs.Empty);
        }

        private void OnEnd()
        {
            if (OnGameEnd != null)
            {
                OnGameEnd(this, EventArgs.Empty);
            }
        }

        private void OnTurnStarted(object sender, EventArgs e)
        {
            Console.WriteLine("Turn " + _currentTurn + " started.");
        }
    }
}
