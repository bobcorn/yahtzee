using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yahtzee.View;

namespace Yahtzee.Presenter
{
    public class StatisticsPresenter
    {
        LobbyPresenter _prevPresenter;
        StatisticsForm sf;
        public StatisticsPresenter(LobbyPresenter prevPresenter)
        {
            _prevPresenter = prevPresenter;
               sf= new StatisticsForm(this);
            sf.Show();

        }

        internal void Back()
        {
            sf.Hide();
            _prevPresenter.Show();
        }

        internal void Show()
        {
            sf.Show();
        }
    }
}
