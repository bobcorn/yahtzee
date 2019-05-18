using System;

namespace Yahtzee.View
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this._exitBox = new System.Windows.Forms.PictureBox();
            this._logoBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this._deleteBox = new System.Windows.Forms.PictureBox();
            this._createBox = new System.Windows.Forms.PictureBox();
            this._loadBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this._selectLabel = new System.Windows.Forms.Label();
            this._listBox = new System.Windows.Forms.ListBox();
            this._soundBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this._exitBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._logoBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._deleteBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._createBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._loadBox)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._soundBox)).BeginInit();
            this.SuspendLayout();
            // 
            // _exitBox
            // 
            this._exitBox.BackColor = System.Drawing.Color.Transparent;
            this._exitBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this._exitBox.Image = ((System.Drawing.Image)(resources.GetObject("_exitBox.Image")));
            this._exitBox.Location = new System.Drawing.Point(22, 401);
            this._exitBox.Name = "_exitBox";
            this._exitBox.Size = new System.Drawing.Size(100, 48);
            this._exitBox.TabIndex = 3;
            this._exitBox.TabStop = false;
            this._exitBox.Click += new System.EventHandler(this._exitBox_Click);
            // 
            // _logoBox
            // 
            this._logoBox.BackColor = System.Drawing.Color.Transparent;
            this._logoBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this._logoBox.Image = global::Yahtzee.Properties.Resources.yahtzee_logo_dices_new;
            this._logoBox.Location = new System.Drawing.Point(22, 12);
            this._logoBox.Name = "_logoBox";
            this._logoBox.Size = new System.Drawing.Size(350, 130);
            this._logoBox.TabIndex = 9;
            this._logoBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this._deleteBox);
            this.panel1.Controls.Add(this._createBox);
            this.panel1.Controls.Add(this._loadBox);
            this.panel1.Location = new System.Drawing.Point(195, 185);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 186);
            this.panel1.TabIndex = 6;
            // 
            // _deleteBox
            // 
            this._deleteBox.BackColor = System.Drawing.Color.Transparent;
            this._deleteBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this._deleteBox.Image = global::Yahtzee.Properties.Resources.delete_button;
            this._deleteBox.Location = new System.Drawing.Point(15, 123);
            this._deleteBox.Name = "_deleteBox";
            this._deleteBox.Size = new System.Drawing.Size(156, 48);
            this._deleteBox.TabIndex = 11;
            this._deleteBox.TabStop = false;
            // 
            // _createBox
            // 
            this._createBox.BackColor = System.Drawing.Color.Transparent;
            this._createBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this._createBox.Image = global::Yahtzee.Properties.Resources.create_button;
            this._createBox.Location = new System.Drawing.Point(16, 3);
            this._createBox.Name = "_createBox";
            this._createBox.Size = new System.Drawing.Size(156, 48);
            this._createBox.TabIndex = 10;
            this._createBox.TabStop = false;
            this._createBox.Click += new System.EventHandler(this._createBox_Click);
            // 
            // _loadBox
            // 
            this._loadBox.BackColor = System.Drawing.Color.Transparent;
            this._loadBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this._loadBox.Image = global::Yahtzee.Properties.Resources.load_button;
            this._loadBox.Location = new System.Drawing.Point(33, 62);
            this._loadBox.Name = "_loadBox";
            this._loadBox.Size = new System.Drawing.Size(117, 48);
            this._loadBox.TabIndex = 9;
            this._loadBox.TabStop = false;
            this._loadBox.Click += new System.EventHandler(this._loadBox_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this._selectLabel);
            this.panel2.Controls.Add(this._listBox);
            this.panel2.Location = new System.Drawing.Point(22, 177);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(167, 194);
            this.panel2.TabIndex = 10;
            // 
            // _selectLabel
            // 
            this._selectLabel.AutoSize = true;
            this._selectLabel.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold);
            this._selectLabel.Location = new System.Drawing.Point(-4, 0);
            this._selectLabel.Name = "_selectLabel";
            this._selectLabel.Size = new System.Drawing.Size(128, 21);
            this._selectLabel.TabIndex = 11;
            this._selectLabel.Text = "Select a profile:";
            // 
            // _listBox
            // 
            this._listBox.FormattingEnabled = true;
            this._listBox.Location = new System.Drawing.Point(0, 26);
            this._listBox.Name = "_listBox";
            this._listBox.Size = new System.Drawing.Size(167, 173);
            this._listBox.TabIndex = 0;
            this._listBox.SelectedIndexChanged += new System.EventHandler(this._listBox_SelectedIndexChanged);
            // 
            // _soundBox
            // 
            this._soundBox.BackColor = System.Drawing.Color.Transparent;
            this._soundBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this._soundBox.Image = global::Yahtzee.Properties.Resources.soundoff_button;
            this._soundBox.Location = new System.Drawing.Point(324, 401);
            this._soundBox.Name = "_soundBox";
            this._soundBox.Size = new System.Drawing.Size(48, 48);
            this._soundBox.TabIndex = 12;
            this._soundBox.TabStop = false;
            // 
            // MenuForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImage = global::Yahtzee.Properties.Resources._256x256_Finale;
            this.ClientSize = new System.Drawing.Size(399, 450);
            this.Controls.Add(this._soundBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this._logoBox);
            this.Controls.Add(this._exitBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MenuForm";
            this.Text = "Yahtzee!";
            this.Load += new System.EventHandler(this.MenuForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this._exitBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._logoBox)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._deleteBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._createBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._loadBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._soundBox)).EndInit();
            this.ResumeLayout(false);

        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.PictureBox _exitBox;
        private System.Windows.Forms.PictureBox _logoBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox _listBox;
        private System.Windows.Forms.Label _selectLabel;
        private System.Windows.Forms.PictureBox _loadBox;
        private System.Windows.Forms.PictureBox _createBox;
        private System.Windows.Forms.PictureBox _deleteBox;
        private System.Windows.Forms.PictureBox _soundBox;
    }
}