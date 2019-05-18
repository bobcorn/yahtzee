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
    public partial class StatisticsForm : Form
    {
        private StatisticsPresenter _presenter;

        public StatisticsForm(StatisticsPresenter presenter)
        {
            InitializeComponent();
            _presenter = presenter;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _presenter.Back();
        }
    }
}
