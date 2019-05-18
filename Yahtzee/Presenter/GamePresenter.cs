using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Yahtzee.Model;
using Yahtzee.View;

namespace Yahtzee.Presenter
{
    public class GamePresenter 
    {
        private IGameView _target;
        private IGame _game;
        private LobbyPresenter _prevPresenter;
        private String _user, _diff;
        private int _numBot;
        public GamePresenter(LobbyPresenter _preview, String User, int numBot,String difficulty)
        {
            _user = User;
            _numBot = numBot;
            _diff = difficulty;
            _prevPresenter = _preview;
            List<IPlayer> _players = PlayerFactory.getInstance(numBot,User,difficulty);

            _game =GameFactory.getGameInstance(_players);

            _game.OnGameEnd += new EventHandler(OnGameEnd);
            _game.Scoreboard.CombinationApplied += new EventHandler(OnCombinationApplied);
            _game.Dices.DicesRolled += new EventHandler<RollEventArgs>(OnDiceRolled);
            _game.Dices.DiceKept += new EventHandler<KeepEventArgs>(OnDiceKept);
            _game.CurrentPlayerTurn.FinishedRolls +=OnFinishedRolls;
            _game.PlayerTurnEnd += OnPlayerTurnEnded;
            _game.PlayerTurnStarted += OnPlayerTurnStarted;

            
        }

        internal void Show()
        {
            if(_target==null)
             _target = GameViewFactory.getInstance(this, _user, _numBot, _diff);
            OnGameStart();
            _target.ShowForm();
           
        }

        private void OnCombinationApplied(object sender, EventArgs e)
        {
            _target.ApplyCombination(_game.CurrentPlayer.Name, ((Combination)sender).Name);
        }

        private void OnPlayerTurnStarted(PlayerTurn sender, EventArgs e)
        {
            IPlayer player = sender.Player;

            if ((player is IBot bot)) 
            {

                // Disable controls!
                _target.DisableRollButton();

                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;

                    ICommand c = null;
                    do
                    {
                        Thread.Sleep(750);
                        c = bot.DoSomething(_game);
                        c.Execute(_game);
                    } while (c.GetType() != typeof(SelectCombinationCommand));
                }).Start();
            }
            else
            {
                _target.EnableRollButton();
            }
        }

        private void OnPlayerTurnEnded(object sender, EventArgs e)
        {
            _game.Dices.ReleaseAll();
            _target.ResetLocksAndRolls();
            _target.UpdateTotalScore(_game.CurrentPlayer.Name, _game.Scoreboard.CalculateTotalScoreForPlayer(_game.CurrentPlayer));
            _target.UpdateSumAndBonus(_game.CurrentPlayer.Name, _game.Scoreboard.CalculateSumForPlayer(_game.CurrentPlayer), _game.Scoreboard.CalculateBonusScoreForPlayer(_game.CurrentPlayer));

            foreach (Combination c in _game.Scoreboard.Combinations)
                if (!c.UsedByPlayer(_game.CurrentPlayer))
                    _target.CleanPlayerCombination(((PlayerTurn)sender).Player.Name, c.Name);
        }

        private void OnGameEnd(object sender, EventArgs e)
        {
            string msg = "";

            foreach (IPlayer p in _game.Players)
                msg += p.Name + ": " + _game.Scoreboard.CalculateTotalScoreForPlayer(p) + "\n";

            msg += "\nWinner: " + _game.Scoreboard.GetWinner().Name.ToUpper() + "!!!";
            _target.ShowMessage(msg);
        }

        private void OnFinishedRolls(object sender, EventArgs e)
        {
            _target.DisableRollButton();
        }

        private void OnDiceRolled(object sender, RollEventArgs e)
        {
            Console.WriteLine("Dices rolled: [" + string.Join(",", e.Values) + "]");

            _target.RollDices(e.Values);
            _target.UpdateRemainingRolls(_game.CurrentPlayerTurn.RemainingRolls);

            foreach (Combination c in _game.Scoreboard.Combinations)
            {
                if (!c.UsedByPlayer(_game.CurrentPlayer))
                {
                    int score = c.CalculateScore(_game.Dices);
                    _target.UpdateCombination(c.Name, _game.CurrentPlayer.Name, score);
                }
            }
        }

        private void OnDiceKept(object sender, KeepEventArgs e)
        {
            if (e.Kept)
            {
                Console.WriteLine("Dice " + (e.Index + 1) + " kept.");
                _target.KeepDice(e.Index, e.Value);
            }
            else
            {
                Console.WriteLine("Dice " + (e.Index + 1) + " released.");
                _target.ReleaseDice(e.Index, e.Value);

                if (_game.CurrentPlayerTurn.RemainingRolls != 0)
                    _target.EnableRollButton();
            }

            if (_game.Dices.AllKept())
                _target.DisableRollButton();
        }

        public void OnGameStart()
        {
            List<string> combinationsNames = new List<string>();
            List<string> playersNames = new List<string>();

            foreach (Combination c in _game.Scoreboard.Combinations)
                combinationsNames.Add(c.Name);

            foreach (IPlayer p in _game.Players)
                playersNames.Add(p.Name);

            _target.InitializeScoreboard(playersNames, combinationsNames);
        }

        public void OnRollButtonClick(object sender, EventArgs e)
        {
            new RollDicesCommand().Execute(_game);
        }

        public void OnDiceClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (_game.CurrentPlayerTurn.RemainingRolls != 3)
            {
                if (sender.Equals(_target.Dice1))
                    new KeepDiceCommand(0, !_game.Dices.Kept[0]).Execute(_game);
                else if (sender.Equals(_target.Dice2))
                    new KeepDiceCommand(1, !_game.Dices.Kept[1]).Execute(_game);
                else if (sender.Equals(_target.Dice3))
                    new KeepDiceCommand(2, !_game.Dices.Kept[2]).Execute(_game);
                else if (sender.Equals(_target.Dice4))
                    new KeepDiceCommand(3, !_game.Dices.Kept[3]).Execute(_game);
                else if (sender.Equals(_target.Dice5))
                    new KeepDiceCommand(4, !_game.Dices.Kept[4]).Execute(_game);
                else
                    throw new Exception("CheckBoxChanged by who?");
            }
            else { _target.ShowMessage("You must throw first!"); }
        }

        public void OnCombinationClick(string name)
        {
            foreach (Combination c in _game.Scoreboard.Combinations)
            {
                if (c.Name.Equals(name))
                {
                    new SelectCombinationCommand(c).Execute(_game);
                    break;
                }
            }
        }

        internal void Back()
        {
            _target.HideForm();
            _target.Stop();
            _target = null;
            _prevPresenter.Show();

        }

        
    }
}
