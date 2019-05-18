using System;
using System.Collections.Generic;

namespace Yahtzee.Model
{
    interface IGame
    {
        IPlayer CurrentPlayer { get; }
        PlayerTurn CurrentPlayerTurn { get; }
        ITurn CurrentTurn { get; }
        IDices Dices { get; }
        List<IPlayer> Players { get; }
        Scoreboard Scoreboard { get; }

        event EventHandler OnGameEnd;
        event EventHandler OnGameStart;
        event PlayerTurnEventHandler PlayerTurnEnd;
        event PlayerTurnEventHandler PlayerTurnStarted;

        void NewTurn();
        void RollDices();
        void UseCombination(Combination c);
    }
}