using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yahtzee.Presenter;

namespace Yahtzee.View
{
    static class GameViewFactory
    {
        public static IGameView getInstance(GamePresenter presenter,String User,int numbot,String diff)
        {
            return new GameForm(presenter,User,numbot,diff);
        }
    }
}
