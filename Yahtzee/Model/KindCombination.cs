using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee.Model
{
    class KindCombination : Combination
    {
        private string _name;

        public override string Name
        {
            get { return _name; }
        }
        public KindCombination(List<IPlayer> players, string name) : base(players)
        {
            _name = name;
        }




        public override int CalculateScore(IDices dices)
        {
            switch (Name)
            {
                case "Tris":
                    if (HowManyEquals(dices) > 2)
                        return Sum(dices);
                    break;
                case "Poker":
                    if (HowManyEquals(dices) > 3)
                        return Sum(dices);
                    break;
                case "Yahtzee":
                    if (HowManyEquals(dices) ==5)
                        return 50;
                    break;
                case "Full":
                    return Full(dices);
                case "Chance":
                    return Sum(dices);
                default: throw new ArgumentException("name not valid: " + Name);

            }
            return 0;

        }

        private int Full(IDices dices)
        {
            int[] nums = new int[6];
            int firstValue = dices.GetValues()[0];
            int secondValue=-1;
            foreach (int value in dices.GetValues())
            {
                if (value != firstValue)
                    secondValue = value;

            }
            int countFirst = 0;
            int countSecond = 0;
            foreach (int value in dices.GetValues())
            {
                if (value ==firstValue)
                    countFirst++;
                if (value == secondValue)
                    countSecond++;

            }
            if(((countSecond==3)&& (countFirst==2))|| ((countFirst == 3) && (countSecond == 2)))
                return 25;
            return 0;


        }
        private int Sum(IDices dices)
        {
            int res = 0;
            foreach (int value in dices.GetValues())
                res += value;
            return res;
        }
        private int HowManyEquals(IDices dices)
        {
            int[] nums= new int[6];
            foreach(int value in dices.GetValues())
            {
                nums[value-1]++;

            }
            int max = 0;
            foreach(int val in nums)
                if (val > max)
                    max = val;
            return max;

        }
    }
}
