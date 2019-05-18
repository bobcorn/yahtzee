using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yahtzee.Model;

namespace Yahtzee.View
{
    interface IMenuView
    {
        PictureBox Dice1 { get; }
        PictureBox Dice2 { get; }
        PictureBox Dice3 { get; }
        PictureBox Dice4 { get; }
        PictureBox Dice5 { get; }
        Button RollButton { get; }

        void UpdateDices(int[] values);
        void KeepDice(int index, int value);
        void ReleaseDice(int index, int value);
        void InitializeScoreboard(List<string> playersNames, List<string> combinationsNames);
        void UpdateCombination(string name, int score);
        void OnAllDicesKept();
        void FinishedRolls();
        void DisableRoll();
        void UpdateRemainingRolls(int remainingRolls);
        void ShowMessage(string v);
    }
}
