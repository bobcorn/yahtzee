using System;

namespace Yahtzee.Model
{
    interface IDices
    {
        bool[] Kept { get; }

        event EventHandler<KeepEventArgs> DiceKept;
        event EventHandler<RollEventArgs> DicesRolled;

        bool AllKept();
        int[] GetValues();
        void Keep(int index, bool keep);
        void ReleaseAll();
        void Roll();
    }
}