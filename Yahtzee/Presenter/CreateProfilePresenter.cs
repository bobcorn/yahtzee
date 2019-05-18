using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yahtzee.View;

namespace Yahtzee.Presenter
{
    public class CreateProfilePresenter
    {
        MenuPresenter _prevPresenter;
        CreateProfileForm _form;
        public CreateProfilePresenter(MenuPresenter prevPresenter)
        {
            _prevPresenter = prevPresenter;
            _form = new CreateProfileForm(this);
            _form.Show();


        }
        public void GoBack()
        {
            _form.Hide();
            _prevPresenter.Show();
        }

        internal void Show()
        {
            _form.Show();
        }
    }
}
