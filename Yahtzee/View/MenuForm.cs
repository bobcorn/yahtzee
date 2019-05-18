using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yahtzee.Presenter;

namespace Yahtzee.View
{
    public partial class MenuForm : Form
    {
        private bool _sound;
        private MenuPresenter _presenter;
        public MenuForm(MenuPresenter presenter)
        {
            _presenter = presenter;
            InitializeComponent();

            //List filled with debug values
            _listBox.Items.Add("Marco");
            _listBox.Items.Add("Matteo");
            _listBox.Items.Add("Simone");

            //Buttons image initialization
            _exitBox.Image = Properties.Resources.exit_button;
            _loadBox.Image = Properties.Resources.load_button;
            _createBox.Image = Properties.Resources.create_button;
            _soundBox.Image = Properties.Resources.soundon_button;
            
            if (_listBox.SelectedIndices.Count == 0)
                _deleteBox.Image = Properties.Resources.delete_button_disabled;

            else
                _deleteBox.Image = Properties.Resources.delete_button;

            if (_listBox.SelectedIndices.Count == 0)
                _loadBox.Image = Properties.Resources.load_button_disabled;

            else
                _loadBox.Image = Properties.Resources.load_button;

            //exitBox events initialization
            _exitBox.MouseEnter += new EventHandler(OnMouseOverExit);
            _exitBox.MouseLeave += new EventHandler(OnMouseLeaveExit);
            _exitBox.MouseDown += new MouseEventHandler(OnExitDown);
            _exitBox.MouseUp += new MouseEventHandler(OnExitUp);
            _exitBox.Click += new EventHandler(OnExitClick);

            //loadBox events initialization
            _loadBox.MouseEnter += new EventHandler(OnMouseOverLoad);
            _loadBox.MouseLeave += new EventHandler(OnMouseLeaveLoad);
            _loadBox.MouseDown += new MouseEventHandler(OnLoadDown);
            _loadBox.MouseUp += new MouseEventHandler(OnLoadUp);
            _loadBox.Click += new EventHandler(OnLoadClick);

            //deleteBox events initialization
            _deleteBox.MouseEnter += new EventHandler(OnMouseOverDelete);
            _deleteBox.MouseLeave += new EventHandler(OnMouseLeaveDelete);
            _deleteBox.MouseDown += new MouseEventHandler(OnDeleteDown);
            _deleteBox.MouseUp += new MouseEventHandler(OnDeleteUp);
            _deleteBox.Click += new EventHandler(OnDeleteClick);

            //createBox events initialization
            _createBox.MouseEnter += new EventHandler(OnMouseOverCreate);
            _createBox.MouseLeave += new EventHandler(OnMouseLeaveCreate);
            _createBox.MouseDown += new MouseEventHandler(OnCreateDown);
            _createBox.MouseUp += new MouseEventHandler(OnCreateUp);
            _createBox.Click += new EventHandler(OnCreateClick);

            //soundBox events initialization
            _soundBox.MouseEnter += new EventHandler(OnMouseOverSound);
            _soundBox.MouseLeave += new EventHandler(OnMouseLeaveSound);
            _soundBox.MouseDown += new MouseEventHandler(OnSoundDown);
            _soundBox.MouseUp += new MouseEventHandler(OnSoundUp);
            _soundBox.Click += new EventHandler(OnSoundClick);

            _listBox.SelectedIndexChanged += new EventHandler(OnListSelection);
        }

        //ListBox events

        private void OnListSelection(object sender, EventArgs e)
        {
            _deleteBox.Image = Properties.Resources.delete_button;
            _loadBox.Image = Properties.Resources.load_button;
        }

        //Sound events

        private void OnSoundClick(object sender, EventArgs e)
        {
            if (_sound == true)
            {
                _soundBox.Image = Properties.Resources.soundon_button_mouseover;
                _sound = false;
            }

            else if (_sound == false)
            {
                System.Media.SoundPlayer _mouseClickPlayer = new System.Media.SoundPlayer(Properties.Resources.clickSound);
                _mouseClickPlayer.Play();
                _soundBox.Image = Properties.Resources.soundon_button_mouseover;
                _sound = true;
            }
        }

        private void OnSoundUp(object sender, MouseEventArgs e)
        {
            if (_sound == true)
                _soundBox.Image = Properties.Resources.soundon_button_mouseover;

            else if (_sound == false)
                _soundBox.Image = Properties.Resources.soundoff_button_mouseover;
        }

        private void OnSoundDown(object sender, MouseEventArgs e)
        {
            if (_soundBox.Image.Equals(Properties.Resources.soundoff_button_mouseover))
                _soundBox.Image = Properties.Resources.soundoff_button_clicked;

            else
                _soundBox.Image = Properties.Resources.soundon_button_clicked;
        }

        private void OnMouseLeaveSound(object sender, EventArgs e)
        {
            if (_sound == true)
                _soundBox.Image = Properties.Resources.soundon_button;

            else if (_sound == false)
                _soundBox.Image = Properties.Resources.soundoff_button;
        }

        private void OnMouseOverSound(object sender, EventArgs e)
        {
            System.Media.SoundPlayer _mouseOverPlayer = new System.Media.SoundPlayer(Properties.Resources.mouseOverSound);
            _mouseOverPlayer.Play();

            if (_sound == true)
                _soundBox.Image = Properties.Resources.soundon_button_mouseover;

            else if (_sound == false)
                _soundBox.Image = Properties.Resources.soundoff_button_mouseover;
        }

        //Create events

        private void OnCreateClick(object sender, EventArgs e)
        {
            System.Media.SoundPlayer _mouseClickPlayer = new System.Media.SoundPlayer(Properties.Resources.clickSound);
            _mouseClickPlayer.Play();

            _presenter.Create();
        }

        private void OnCreateUp(object sender, MouseEventArgs e)
        {
            _createBox.Image = Properties.Resources.create_button_mouseover;
        }

        private void OnCreateDown(object sender, MouseEventArgs e)
        {
            _createBox.Image = Properties.Resources.create_button_clicked;
        }

        private void OnMouseLeaveCreate(object sender, EventArgs e)
        {
            _createBox.Image = Properties.Resources.create_button;
        }

        private void OnMouseOverCreate(object sender, EventArgs e)
        {
            System.Media.SoundPlayer _mouseOverPlayer = new System.Media.SoundPlayer(Properties.Resources.mouseOverSound);
            _mouseOverPlayer.Play();
            _createBox.Image = Properties.Resources.create_button_mouseover;
        }

        //Delete events

        private void OnDeleteClick(object sender, EventArgs e)
        {
            if (_listBox.SelectedItems.Count == 1)
            {
                System.Media.SoundPlayer _mouseClickPlayer = new System.Media.SoundPlayer(Properties.Resources.clickSound);
                _mouseClickPlayer.Play();
            }

                if (_listBox.SelectedItems.Count == 0)
            {
                System.Media.SoundPlayer _mouseClickPlayer = new System.Media.SoundPlayer(Properties.Resources.errorSound);
                _mouseClickPlayer.Play();
            }
        }

        private void OnDeleteUp(object sender, MouseEventArgs e)
        {
            if (_listBox.SelectedIndices.Count == 0)
                _deleteBox.Image = Properties.Resources.delete_button_disabled;

            else
                _deleteBox.Image = Properties.Resources.delete_button_mouseover;
        }

        private void OnDeleteDown(object sender, MouseEventArgs e)
        {
            if (_listBox.SelectedIndices.Count == 0)
                _deleteBox.Image = Properties.Resources.delete_button_disabled;

            else
                _deleteBox.Image = Properties.Resources.delete_button_clicked;
        }

        private void OnMouseLeaveDelete(object sender, EventArgs e)
        {
            if (_listBox.SelectedIndices.Count == 0)
                _deleteBox.Image = Properties.Resources.delete_button_disabled;

            else
                _deleteBox.Image = Properties.Resources.delete_button;
        }

        private void OnMouseOverDelete(object sender, EventArgs e)
        {
            System.Media.SoundPlayer _mouseOverPlayer = new System.Media.SoundPlayer(Properties.Resources.mouseOverSound);
            _mouseOverPlayer.Play();

            if (_listBox.SelectedIndices.Count == 0)
                _deleteBox.Image = Properties.Resources.delete_button_disabled;

            else
                _deleteBox.Image = Properties.Resources.delete_button_mouseover;
        }

        //Load events

        private void OnLoadClick(object sender, EventArgs e)
        {
            if (_listBox.SelectedItems.Count == 1)
            {
                System.Media.SoundPlayer _mouseClickPlayer = new System.Media.SoundPlayer(Properties.Resources.clickSound);
                _mouseClickPlayer.Play();
                
                
            }

            if (_listBox.SelectedItems.Count == 0)
            {
                System.Media.SoundPlayer _mouseClickPlayer = new System.Media.SoundPlayer(Properties.Resources.errorSound);
                _mouseClickPlayer.Play();
            }
        }

        private void OnLoadUp(object sender, MouseEventArgs e)
        {
            if (_listBox.SelectedIndices.Count == 0)
                _loadBox.Image = Properties.Resources.load_button_disabled;

            else
                _loadBox.Image = Properties.Resources.load_button_mouseover;
        }

        private void OnLoadDown(object sender, MouseEventArgs e)
        {
            if (_listBox.SelectedIndices.Count == 0)
                _loadBox.Image = Properties.Resources.load_button_disabled;

            else
                _loadBox.Image = Properties.Resources.load_button_clicked;
        }

        private void OnMouseLeaveLoad(object sender, EventArgs e)
        {
            if (_listBox.SelectedIndices.Count == 0)
                _loadBox.Image = Properties.Resources.load_button_disabled;

            else
                _loadBox.Image = Properties.Resources.load_button;
        }

        private void OnMouseOverLoad(object sender, EventArgs e)
        {
            System.Media.SoundPlayer _mouseOverPlayer = new System.Media.SoundPlayer(Properties.Resources.mouseOverSound);
            _mouseOverPlayer.Play();

            if (_listBox.SelectedIndices.Count == 0)
                _loadBox.Image = Properties.Resources.load_button_disabled;

            else
                _loadBox.Image = Properties.Resources.load_button_mouseover;
        }

        //Exit events

        private void OnExitClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnExitUp(object sender, MouseEventArgs e)
        {
            _exitBox.Image = Properties.Resources.exit_button_mouseover;
        }

        private void OnExitDown(object sender, EventArgs e)
        {
            _exitBox.Image = Properties.Resources.exit_button_clicked;
        }

        private void OnMouseLeaveExit(object sender, EventArgs e)
        {
            _exitBox.Image = Properties.Resources.exit_button;
        }

        private void OnMouseOverExit(object sender, EventArgs e)
        {
            System.Media.SoundPlayer _mouseOverPlayer = new System.Media.SoundPlayer(Properties.Resources.mouseOverSound);
            _mouseOverPlayer.Play();
            _exitBox.Image = Properties.Resources.exit_button_mouseover;
        }

        private void _loadBox_Click(object sender, EventArgs e)
        {

            _presenter.loadProfile(_listBox.SelectedItem.ToString());
            
        }

        private void _listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MenuForm_Load_1(object sender, EventArgs e)
        {

        }

        private void _createBox_Click(object sender, EventArgs e)
        {

        }

        private void _exitBox_Click(object sender, EventArgs e)
        {

        }
    }
}
