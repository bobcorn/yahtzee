using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yahtzee.Model;
using Yahtzee.Presenter;
using Yahtzee.View;

namespace Yahtzee
{
    public partial class GameForm : Form, IGameView
    {
        private GamePresenter _gamePresenter;
        private PictureBox[] _dices;
        private PictureBox[] _locks;
        private Font _previewFont, _usedFont;
        private System.Media.SoundPlayer _mouseClickPlayer;

        public GameForm(GamePresenter presenter,  String User, int numBot, String difficulty)
        {
            InitializeComponent();

            _gamePresenter = presenter;
            _mouseClickPlayer = new System.Media.SoundPlayer(Properties.Resources.dicesRollSound);

            _rollButton.Click += new EventHandler(_gamePresenter.OnRollButtonClick);
            _rollButton.MouseDown += new MouseEventHandler(RollButtonDown);
            _rollButton.MouseUp += new MouseEventHandler(RollButtonUp);
            _rollButton.EnabledChanged += new EventHandler(RollButtonEnabledChanged);

            _ffButton.MouseEnter += new EventHandler(OnMouseOverFFButton);
            _ffButton.MouseLeave += new EventHandler(OnMouseLeaveFFButton);
            _ffButton.MouseDown += new MouseEventHandler(FFButtonDown);
            _ffButton.MouseUp += new MouseEventHandler(FFButtonUp);
            _ffButton.Click += new EventHandler(FFButtonClick);

            MouseEventHandler checkChanges = new MouseEventHandler(_gamePresenter.OnDiceClick);
            _dice1.MouseClick += checkChanges;
            _dice2.MouseClick += checkChanges;
            _dice3.MouseClick += checkChanges;
            _dice4.MouseClick += checkChanges;
            _dice5.MouseClick += checkChanges;

            // List of dices pictureboxes
            _dices = new PictureBox[5];
            _dices[0] = _dice1;
            _dices[1] = _dice2;
            _dices[2] = _dice3;
            _dices[3] = _dice4;
            _dices[4] = _dice5;

            _locks = new PictureBox[5];
            _locks[0] = _lock1;
            _locks[1] = _lock2;
            _locks[2] = _lock3;
            _locks[3] = _lock4;
            _locks[4] = _lock5;

            // ToolTip
            // Create the ToolTip and associate with the Form container.
            ToolTip toolTip1 = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 750;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(_rollsLeft, "Rolls left");

            _previewFont = new Font("Ebrima", 9, FontStyle.Bold);
            _usedFont = new Font("Ebrima", 12, FontStyle.Bold);

            _rollsLeft.Image = Properties.Resources._3_throws_left;
            
        }
       

        private void OnMouseLeaveFFButton(object sender, EventArgs e)
        {
            _ffButton.Image = Properties.Resources.flag;
        }

        private void OnMouseOverFFButton(object sender, EventArgs e)
        {
            System.Media.SoundPlayer _mouseOverPlayer = new System.Media.SoundPlayer(Properties.Resources.mouseOverSound);
            _mouseOverPlayer.Play();
            _ffButton.Image = Properties.Resources.flag_mouseover;
        }

        private void FFButtonClick(object sender, EventArgs e)
        {
            System.Media.SoundPlayer _mouseClickPlayer = new System.Media.SoundPlayer(Properties.Resources.clickSound);
            _mouseClickPlayer.Play();
        }

        private void FFButtonUp(object sender, MouseEventArgs e)
        {
            _ffButton.Image = Properties.Resources.flag_mouseover;
        }

        private void FFButtonDown(object sender, EventArgs e)
        {
            _ffButton.Image = Properties.Resources.flag_clicked;
        }

        private void RollButtonEnabledChanged(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Enabled)
                _rollButton.BackgroundImage = Properties.Resources.button;
            else
                _rollButton.BackgroundImage = Properties.Resources.roll_button_disabled;
        }

        private void RollButtonUp(object sender, MouseEventArgs e)
        {
            // If is enabled, update graphics
            if (_rollButton.Enabled)
                _rollButton.BackgroundImage = Properties.Resources.button;
        }

        private void RollButtonDown(object sender, MouseEventArgs e)
        {
            _rollButton.BackgroundImage = Properties.Resources.button_clicked;
        }

        public PictureBox Dice1
        {
            get { return _dice1; }
        }

        public PictureBox Dice2
        {
            get { return _dice2; }
        }

        public PictureBox Dice3
        {
            get { return _dice3; }
        }

        public PictureBox Dice4
        {
            get { return _dice4; }
        }

        public PictureBox Dice5
        {
            get { return _dice5; }
        }

        public Button RollButton
        {
            get { return _rollButton; }
        }

        public void KeepDice(int idx, int value)
        {
            switch (value)
            {
                case 1:
                    _dices[idx].Image = Properties.Resources._1_kept;
                    break;
                case 2:
                    _dices[idx].Image = Properties.Resources._2_kept;
                    break;
                case 3:
                    _dices[idx].Image = Properties.Resources._3_kept;
                    break;
                case 4:
                    _dices[idx].Image = Properties.Resources._4_kept;
                    break;
                case 5:
                    _dices[idx].Image = Properties.Resources._5_kept;
                    break;
                case 6:
                    _dices[idx].Image = Properties.Resources._6_kept;
                    break;
            }
            _locks[idx].Image = Properties.Resources._lock;
        }

        public void RollDices(int[] values)
        {
            _mouseClickPlayer.Play();

            for (int i = 0; i < values.Length; i++)
            {
                switch (values[i])
                {
                    case -1:
                        break;
                    case 1:
                        _dices[i].Image = Properties.Resources._1;
                        _locks[i].Image = Properties.Resources.unlock;
                        break;
                    case 2:
                        _dices[i].Image = Properties.Resources._2;
                        _locks[i].Image = Properties.Resources.unlock;
                        break;
                    case 3:
                        _dices[i].Image = Properties.Resources._3;
                        _locks[i].Image = Properties.Resources.unlock;
                        break;
                    case 4:
                        _dices[i].Image = Properties.Resources._4;
                        _locks[i].Image = Properties.Resources.unlock;
                        break;
                    case 5:
                        _dices[i].Image = Properties.Resources._5;
                        _locks[i].Image = Properties.Resources.unlock;
                        break;
                    case 6:
                        _dices[i].Image = Properties.Resources._6;
                        _locks[i].Image = Properties.Resources.unlock;
                        break;
                    default:
                        throw new Exception("Invalid value");
                }
            }
        }

        public void ReleaseDice(int idx, int value)
        {
            switch (value)
            {
                case 1:
                    _dices[idx].Image = Properties.Resources._1;
                    break;
                case 2:
                    _dices[idx].Image = Properties.Resources._2;
                    break;
                case 3:
                    _dices[idx].Image = Properties.Resources._3;
                    break;
                case 4:
                    _dices[idx].Image = Properties.Resources._4;
                    break;
                case 5:
                    _dices[idx].Image = Properties.Resources._5;
                    break;
                case 6:
                    _dices[idx].Image = Properties.Resources._6;
                    break;
            }
            _locks[idx].Image = Properties.Resources.unlock;
        }

        public void InitializeScoreboard(List<string> playersNames, List<string> combinationNames)
        {
            int combIdx = 4, nameIdx = 1;

            foreach (string name in playersNames)
                nameIdx++;
            foreach (string name in combinationNames)
                combIdx++;

            _scoreboardPanel.RowCount = combIdx;
            _scoreboardPanel.ColumnCount = nameIdx;

            Label[][] scoresLabels = new Label[_scoreboardPanel.ColumnCount - 1][];

            for (int i = 0; i < scoresLabels.Length; i++)
                scoresLabels[i] = new Label[_scoreboardPanel.RowCount - 1];


            for (int i = 0; i < scoresLabels.Length; i++)
                for (int j = 0; j < scoresLabels[i].Length; j++)
                {
                    scoresLabels[i][j] = new Label() { Text = "", Font = _previewFont, TextAlign = ContentAlignment.MiddleCenter, Anchor = AnchorStyles.None, AutoSize = false, Dock = DockStyle.Fill, Cursor = Cursors.Hand };
                    _scoreboardPanel.Controls.Add(scoresLabels[i][j], i + 1, j + 1);
                    scoresLabels[i][j].Click += new EventHandler(OnLabelClick);
                    scoresLabels[i][j].Hide();
                }

            _scoreboardPanel.RowStyles.Clear();

            for (int i = 0; i < combIdx; i++)
                _scoreboardPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));

            _scoreboardPanel.ColumnStyles.Clear();

            for (int i = 0; i < nameIdx; i++)
                _scoreboardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));

            combIdx = 1;
            nameIdx = 1;

            foreach (string name in playersNames)
            {
                Panel p = new Panel() { Dock = DockStyle.Fill, Margin = new Padding(0, 0, 0, 0) };
                _scoreboardPanel.Controls.Add(p, nameIdx, 0);
                _scoreboardPanel.GetControlFromPosition(nameIdx++, 0).BackColor = Color.FromArgb(107, 142, 35);
                p.Controls.Add(new Label() { Text = name, Font = new Font("Ebrima", 9, FontStyle.Bold), TextAlign = ContentAlignment.MiddleCenter, Anchor = AnchorStyles.None, AutoSize = false, Dock = DockStyle.Fill });

            }
            foreach (string name in combinationNames)
            {
                if (name.Equals("Tris"))
                {
                    Panel ps = new Panel() { Dock = DockStyle.Fill, Margin = new Padding(0, 0, 0, 0) };
                    _scoreboardPanel.Controls.Add(ps, 0, combIdx);
                    _scoreboardPanel.GetControlFromPosition(0, combIdx++).BackColor = Color.FromArgb(107, 142, 35);
                    ps.Controls.Add(new Label() { Text = "Sum", Font = new Font("Ebrima", 9, FontStyle.Bold), TextAlign = ContentAlignment.MiddleCenter, Anchor = AnchorStyles.None, AutoSize = false, Dock = DockStyle.Fill });

                    Panel pb = new Panel() { Dock = DockStyle.Fill, Margin = new Padding(0, 0, 0, 0) };
                    _scoreboardPanel.Controls.Add(pb, 0, combIdx);
                    _scoreboardPanel.GetControlFromPosition(0, combIdx++).BackColor = Color.FromArgb(107, 142, 35);
                    pb.Controls.Add(new Label() { Text = "Bonus", Font = new Font("Ebrima", 9, FontStyle.Bold), TextAlign = ContentAlignment.MiddleCenter, Anchor = AnchorStyles.None, AutoSize = false, Dock = DockStyle.Fill });
                }

                Panel p = new Panel() { Dock = DockStyle.Fill, Margin = new Padding(0, 0, 0, 0) };
                _scoreboardPanel.Controls.Add(p, 0, combIdx);
                _scoreboardPanel.GetControlFromPosition(0, combIdx++).BackColor = Color.FromArgb(107, 142, 35);
                p.Controls.Add(new Label() { Text = name, Font = new Font("Ebrima", 9, FontStyle.Bold), TextAlign = ContentAlignment.MiddleCenter, Anchor = AnchorStyles.None, AutoSize = false, Dock = DockStyle.Fill });
            }

            // Total score
            Panel p2 = new Panel() { Dock = DockStyle.Fill, Margin = new Padding(0, 0, 0, 0) };
            _scoreboardPanel.Controls.Add(p2, 0, combIdx);
            _scoreboardPanel.GetControlFromPosition(0, combIdx++).BackColor = Color.FromArgb(107, 142, 35);
            p2.Controls.Add(new Label() { Text = "Total score", Font = new Font("Ebrima", 10, FontStyle.Bold), TextAlign = ContentAlignment.MiddleCenter, Anchor = AnchorStyles.None, AutoSize = false, Dock = DockStyle.Fill });
        }

        private void OnLabelClick(object sender, EventArgs e)
        {
            Label l = (Label)sender;
            TableLayoutPanelCellPosition pos = _scoreboardPanel.GetPositionFromControl(l);
            Panel p = (Panel)_scoreboardPanel.GetControlFromPosition(0, pos.Row);
            string name = ((Label)p.Controls[0]).Text;
            _gamePresenter.OnCombinationClick(name);
        }

        public void UpdateCombination(string combName, string playerName, int score)
        {
            TableLayoutPanelCellPosition pos = GetPositionByPlayerCombinationName(playerName, combName);

            Label pointLabel = (Label)_scoreboardPanel.GetControlFromPosition(pos.Column, pos.Row);
            pointLabel.Invoke((MethodInvoker)(() =>
            {
                pointLabel.Text = "" + score;
                pointLabel.Show();
            }));
            
        }

        private TableLayoutPanelCellPosition GetPositionByPlayerCombinationName(string playerName, string combName)
        {
            int posX = -1, posY = -1;

            for (int i = 1; i < _scoreboardPanel.ColumnCount; i++)
            {
                Panel c = (Panel)_scoreboardPanel.GetControlFromPosition(i, 0);
                Label l = (Label)c.Controls[0];

                if (l.Text.Equals(playerName))
                {
                    posX = i;
                    break;
                }
            }

            for (int i = 1; i < _scoreboardPanel.RowCount; i++)
            {
                Panel c = (Panel)_scoreboardPanel.GetControlFromPosition(0, i);
                Label l = (Label)c.Controls[0];

                if (l.Text.Equals(combName))
                {
                    posY = i;
                    break;
                }
            }

            return new TableLayoutPanelCellPosition(posX, posY);
        }

        public void EnableRollButton()
        {
            _rollButton.Invoke((MethodInvoker)(() =>
            {
                _rollButton.Enabled = true;
            }));
        }

        public void DisableRollButton()
        {
            _rollButton.Invoke((MethodInvoker)(() =>
            {
                _rollButton.Enabled = false;
            }));
        }

        public void UpdateRemainingRolls(int remainingRolls)
        {
            Bitmap[] rollsLeft = new Bitmap[4];
            rollsLeft[0] = Properties.Resources._0_throws_left;
            rollsLeft[1] = Properties.Resources._1_throws_left;
            rollsLeft[2] = Properties.Resources._2_throws_left;
            rollsLeft[3] = Properties.Resources._3_throws_left;

            _rollsLeft.Image = rollsLeft[remainingRolls];
        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }

        public void ShowMessage(string v)
        {
            MessageBox.Show(v, "Warning");
        }

        public void CleanPlayerCombination(string playerName, string combName)
        {
            TableLayoutPanelCellPosition pos = GetPositionByPlayerCombinationName(playerName, combName);

            Label l = (Label)_scoreboardPanel.GetControlFromPosition(pos.Column, pos.Row);
            l.Invoke((MethodInvoker)(() =>
            {
                l.Hide();
            }));
        }

        public void ResetLocksAndRolls()
        {
            for (int i = 0; i < _locks.Length; i++)
            {
                _locks[i].Image = null;
            }

            _rollsLeft.Image = Properties.Resources._3_throws_left;
        }

        private void _scoreboardPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        public void ApplyCombination(string playerName, string combName)
        {
            TableLayoutPanelCellPosition pos = GetPositionByPlayerCombinationName(playerName, combName);
            Label l = (Label)_scoreboardPanel.GetControlFromPosition(pos.Column, pos.Row);
            l.ForeColor = Color.Green;
            l.Invoke((MethodInvoker)(() =>
            {
                l.Font = _usedFont;
            })); 
        }

        public void UpdateTotalScore(string playerName, int totalScore)
        {
            TableLayoutPanelCellPosition pos = GetPositionByPlayerCombinationName(playerName, "Total score");

            Label pointLabel = (Label)_scoreboardPanel.GetControlFromPosition(pos.Column, pos.Row);
            pointLabel.Invoke((MethodInvoker)(() =>
            {
                pointLabel.Text = "" + totalScore;
                pointLabel.Show();
            }));
        }

        public void UpdateSumAndBonus(string playerName, int sum, int bonus)
        {
            TableLayoutPanelCellPosition pos = GetPositionByPlayerCombinationName(playerName, "Sum");

            Label pointLabel = (Label)_scoreboardPanel.GetControlFromPosition(pos.Column, pos.Row);
            pointLabel.Invoke((MethodInvoker)(() =>
            {
                pointLabel.Text = "" + sum;
                pointLabel.Show();
            }));

            TableLayoutPanelCellPosition pos2 = GetPositionByPlayerCombinationName(playerName, "Bonus");

            Label pointLabel2 = (Label)_scoreboardPanel.GetControlFromPosition(pos2.Column, pos2.Row);
            pointLabel.Invoke((MethodInvoker)(() =>
            {
                pointLabel2.Text = "" + bonus;
                pointLabel2.Show();
            }));
        }

        private void _ffButton_Click(object sender, EventArgs e)
        {
            _gamePresenter.Back();
            
        }

        public void ShowForm()
        {
            this.ShowDialog();
        }
        public void HideForm()
        {
            this.Hide();
        }
        public void Stop()
        {
            this.Dispose();
        }
    }
}
