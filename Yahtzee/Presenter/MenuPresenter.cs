using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee.Presenter
{
    public class MenuPresenter
    {
        View.MenuForm _form;
        LobbyPresenter lp;
        CreateProfilePresenter cpp;
        public MenuPresenter()
        {

            _form = new View.MenuForm(this);
            Application.Run(_form);

        }

        internal void loadProfile(string user)
        {
            _form.Hide();
            if(lp==null)
            lp = new LobbyPresenter(this,user);
            else
            {
                lp.Show();
            }
           
        }

        internal void Show()
        {
          _form.Show();
        }
        public void Create()
        {
            _form.Hide();
            if (cpp == null)
                cpp = new CreateProfilePresenter(this);
            else
                cpp.Show();

        }
    }
}
