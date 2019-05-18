using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee.Model
{
    class Scoreboard
    {
        private List<IPlayer> _players;
        private List<Combination> _combinations;

        public event EventHandler CombinationApplied;

        public Scoreboard(List<IPlayer> players)
        {
            _players = players;
            _combinations = new List<Combination>();

            _combinations.Add(new FaceCombination(_players, 1));
            _combinations.Add(new FaceCombination(_players, 2));
            _combinations.Add(new FaceCombination(_players, 3));
            _combinations.Add(new FaceCombination(_players, 4));
            _combinations.Add(new FaceCombination(_players, 5));
            _combinations.Add(new FaceCombination(_players, 6));
            _combinations.Add(new KindCombination(_players, "Tris"));
            _combinations.Add(new KindCombination(_players, "Poker"));
            _combinations.Add(new KindCombination(_players, "Full"));
            _combinations.Add(new StraightCombination(_players, "Small Straight"));
            _combinations.Add(new StraightCombination(_players, "Large Straight"));
            _combinations.Add(new KindCombination(_players, "Yahtzee"));
            _combinations.Add(new KindCombination(_players, "Chance"));
        }

        public List<Combination> Combinations
        {
            get { return _combinations; }
        }

        public int CalculateTotalScoreForPlayer(IPlayer player)
        {
            int result = 0;

            foreach (Combination c in _combinations)
                if (c.UsedByPlayer(player))
                    result += c.GetScoreForPlayer(player);

            return result;
        }

        public void SetCombinationForPlayer(IPlayer player, Combination c, IDices dices)
        {
            if (c.UsedByPlayer(player))
                throw new ArgumentException("Combination already set!");

            c.ApplyCombinationForPlayer(player, dices);
            Console.WriteLine("Player " + player.Name + " applied combination " + c.Name + ", with a score of " + c.CalculateScore(dices) + ".");
            OnCombinationApplied(c);

        }

        private void OnCombinationApplied(Combination c)
        {
            if (CombinationApplied != null)
                CombinationApplied(c, EventArgs.Empty);
        }

        public bool IsCombinationUsedForPlayer(IPlayer player, Combination c)
        {
            return c.UsedByPlayer(player);
        }

        public int CalculateSumForPlayer(IPlayer currentPlayer)
        {
            int result = 0;

            foreach (Combination c in _combinations)
                if ((c.Name.Equals("Ones") || c.Name.Equals("Twos") || c.Name.Equals("Threes") || c.Name.Equals("Fours") || c.Name.Equals("Fives") || c.Name.Equals("Sixes")) && c.UsedByPlayer(currentPlayer))
                    result += c.GetScoreForPlayer(currentPlayer);

            return result;
        }

        public int CalculateBonusScoreForPlayer(IPlayer player)
        {
            int bonusSum = 0;

            foreach (Combination c in _combinations)
                if (c.GetType() == typeof(FaceCombination))
                    bonusSum += c.GetScoreForPlayer(player);

            return (bonusSum >= 63) ? 35 : 0;
        }

        public IPlayer GetWinner()
        {
            IPlayer result = null;

            foreach (IPlayer p in _players)
            {
                int score = CalculateTotalScoreForPlayer(p);

                if (result == null)
                    result = p;
                else if (score > CalculateTotalScoreForPlayer(result))
                    result = p;
            }

            return result;
        }
    }
}