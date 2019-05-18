using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yahtzee.Model;

namespace Yahtzee.View
{
    interface IGameView
    {
        PictureBox Dice1 { get; }
        PictureBox Dice2 { get; }
        PictureBox Dice3 { get; }
        PictureBox Dice4 { get; }
        PictureBox Dice5 { get; }
        Button RollButton { get; }

        void RollDices(int[] values);
        void KeepDice(int index, int value);
        void ReleaseDice(int index, int value);
        void InitializeScoreboard(List<string> playersNames, List<string> combinationsNames);
        void UpdateCombination(string combName, string playerName, int score);
        void DisableRollButton();
        void UpdateRemainingRolls(int remainingRolls);
        void ShowMessage(string v);
        void EnableRollButton();
        void CleanPlayerCombination(string playerName, string combName);
        void ResetLocksAndRolls();
        void ApplyCombination(string playerName, string combName);
        void UpdateTotalScore(string playerName, int totalScore);
        void UpdateSumAndBonus(string playerName, int sum, int bonus);
        void ShowForm();
        void HideForm();
        void Stop();
    }
}
