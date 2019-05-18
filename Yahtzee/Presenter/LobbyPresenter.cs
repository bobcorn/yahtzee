using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yahtzee.View;

namespace Yahtzee.Presenter
{
    public class LobbyPresenter
    {
        private MenuPresenter _prevPresenter;
        private LobbyForm _form;
        public GamePresenter _gp;
        private StatisticsPresenter _statsPresenter;
        public LobbyPresenter(MenuPresenter prevPresenter, String User)
        {
            _prevPresenter = prevPresenter;
            _form = new LobbyForm(this,User);
            _form.Show();

        }

        internal void PlayGame(string user, int numbot, String diff)
        {
            if (numbot > 0 && diff != null && diff != "") {
                _form.Hide();
                _gp = new GamePresenter(this, user, numbot, diff);
                _gp.Show();
            }
        }

        internal void Show()
        {
            _form.Show();
        }

        public void GoBack()
        {
            _form.Hide();
            _prevPresenter.Show();
        }

        internal void ShowStatistics()
        {
            _form.Hide();
            if (_statsPresenter == null)
                _statsPresenter = new StatisticsPresenter(this);
            else
                _statsPresenter.Show();
        }
    }
}
