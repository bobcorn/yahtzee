using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yahtzee.Presenter;

namespace Yahtzee.View
{
    public partial class CreateProfileForm : Form
    {
        public String profileName;
        private CreateProfilePresenter _presenter;
        public CreateProfileForm(CreateProfilePresenter presenter)
        {
            _presenter = presenter;
            InitializeComponent();

            _cancelButton.Click += new EventHandler(OnClickCancel);
            _confirmButton.Click += new EventHandler(OnClickConfirm);
        }

        private void OnClickConfirm(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(_newProfileTextBox.Text))
            {
                profileName = _newProfileTextBox.Text;

            }
        }

        private void OnClickCancel(object sender, EventArgs e)
        {
            _presenter.GoBack();
        }

        private void _cancelButton_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CreateProfileForm_Load(object sender, EventArgs e)
        {

        }
    }
}
