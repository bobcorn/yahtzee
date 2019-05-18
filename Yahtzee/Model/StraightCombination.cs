using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee.Model
{
    class StraightCombination : Combination
    {
        private string _name;

        public StraightCombination(List<IPlayer> players, string name) : base(players)
        {
            _name = name;
        }

        public override string Name
        {
            get { return _name; }
        }

       
        public override int CalculateScore(IDices dices)
        {
            int[] values = new int[5];
            values = dices.GetValues();
            Array.Sort(values);
            switch (_name)
            {
                case "Small Straight":
                    if (Straight(values) > 3)
                        return 30;
                    break;
                case "Large Straight":
                    if (Straight(values) > 4)
                        return 40;
                    break;
                default: throw new ArgumentException("name not valid: " + Name);
            }
            return 0;
        }
        
        private int Straight(int[] values)
        {
            
            for(int i=0; i < 2; i++)
            {
                int count = 1;
                for (int c = 0+i; c < values.Length-1; c++)
                {
                    if (values[c] == (values[c + 1] - 1))
                        count++;
                    else
                    {
                        if (values[c] == (values[c + 1]))
                            continue;
                        else
                            break;
                    }
                        
                   
                    
                }
                if (count > 3)
                    return count;
            }
            return 0;
        }
    }
}
