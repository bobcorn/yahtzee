namespace Yahtzee.Model
{

    delegate void TurnEventHandler(ITurn sender, System.EventArgs e);
    interface ITurn
    {
        IPlayer CurrentPlayer { get; }
        PlayerTurn CurrentPlayerTurn { get; }

        event PlayerTurnEventHandler PlayerTurnEnd;
        event PlayerTurnEventHandler PlayerTurnStarted;
        event TurnEventHandler TurnEnded;
        event TurnEventHandler TurnStarted;

        void End();
        void NewPlayerTurn();
        void Start();
    }
}