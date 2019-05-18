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
    public partial class LobbyForm : Form
    {
        private String _user = "";
        private LobbyPresenter _presenter;
        public LobbyForm(LobbyPresenter presenter, String User)
        {
            _presenter = presenter;
            InitializeComponent();
            WelcomeLabel.Text = "Welcome, " + User + "!";
            _user = User;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox2.SelectedItem.ToString().Equals(""))
                    throw new Exception();
                _presenter.PlayGame(_user, Int32.Parse(comboBox1.SelectedItem.ToString()),comboBox2.SelectedItem.ToString());
                
            }catch(Exception exp)
            {
                MessageBox.Show("You need to add at least one bot and choose a difficulty level!"+ exp.Source);
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _presenter.GoBack();
          
        }

        private void LobbyForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            _presenter.ShowStatistics();
        }
    }
}
