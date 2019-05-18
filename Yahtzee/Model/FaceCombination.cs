using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee.Model
{
    class FaceCombination : Combination
    {
        private int _diceValue;

        override public string Name
        {
            get {
                switch (_diceValue)
                {
                    case 1:
                        return "Ones";
                    case 2:
                        return "Twos";
                    case 3:
                        return "Threes";
                    case 4:
                        return "Fours";
                    case 5:
                        return "Fives";
                    case 6:
                        return "Sixes";
                    default:
                        return "Unknown";
                }
            }
        }
        

        public FaceCombination(List<IPlayer> players, int diceValue): base(players)
        {
            _diceValue = diceValue;
            
          
        }

        override public int CalculateScore(IDices dices)
        {
            int result = 0;
            int[] values = dices.GetValues();

            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == _diceValue)
                    result += _diceValue;
            }

            return result;
        }

       
    }
}