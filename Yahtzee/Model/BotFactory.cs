using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee.Model
{
    static class BotFactory
    {
        static public IBot getInstance(string name, int difficulty)
        {
            switch (difficulty)
            {
                case 1:
                    return new EasyBot(name);
                    
                case 2: return new MediumBot(name);
                   
                case 3: return new HardBot(name);
                    
                default: return new EasyBot(name);
            }
                    
        }
    }
}
