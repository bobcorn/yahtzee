namespace Yahtzee
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this._dicePanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this._lock5 = new System.Windows.Forms.PictureBox();
            this._lock4 = new System.Windows.Forms.PictureBox();
            this._lock3 = new System.Windows.Forms.PictureBox();
            this._lock2 = new System.Windows.Forms.PictureBox();
            this._lock1 = new System.Windows.Forms.PictureBox();
            this._dice5 = new System.Windows.Forms.PictureBox();
            this._dice4 = new System.Windows.Forms.PictureBox();
            this._dice1 = new System.Windows.Forms.PictureBox();
            this._dice2 = new System.Windows.Forms.PictureBox();
            this._dice3 = new System.Windows.Forms.PictureBox();
            this._scoreboardPanel = new System.Windows.Forms.TableLayoutPanel();
            this._sbPanel = new System.Windows.Forms.Panel();
            this._rollButton = new System.Windows.Forms.Button();
            this._rollsLeft = new System.Windows.Forms.PictureBox();
            this._ffButton = new System.Windows.Forms.PictureBox();
            this._soundBox = new System.Windows.Forms.PictureBox();
            this._dicePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._lock5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lock4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lock3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lock2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lock1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dice5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dice4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dice3)).BeginInit();
            this._sbPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._rollsLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ffButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._soundBox)).BeginInit();
            this.SuspendLayout();
            // 
            // _dicePanel
            // 
            this._dicePanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._dicePanel.BackColor = System.Drawing.Color.Transparent;
            this._dicePanel.Controls.Add(this.panel1);
            this._dicePanel.Controls.Add(this._lock5);
            this._dicePanel.Controls.Add(this._lock4);
            this._dicePanel.Controls.Add(this._lock3);
            this._dicePanel.Controls.Add(this._lock2);
            this._dicePanel.Controls.Add(this._lock1);
            this._dicePanel.Controls.Add(this._dice5);
            this._dicePanel.Controls.Add(this._dice4);
            this._dicePanel.Controls.Add(this._dice1);
            this._dicePanel.Controls.Add(this._dice2);
            this._dicePanel.Controls.Add(this._dice3);
            this._dicePanel.Location = new System.Drawing.Point(174, 530);
            this._dicePanel.Name = "_dicePanel";
            this._dicePanel.Size = new System.Drawing.Size(386, 113);
            this._dicePanel.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 62);
            this.panel1.TabIndex = 17;
            // 
            // _lock5
            // 
            this._lock5.Location = new System.Drawing.Point(330, 90);
            this._lock5.Name = "_lock5";
            this._lock5.Size = new System.Drawing.Size(20, 20);
            this._lock5.TabIndex = 21;
            this._lock5.TabStop = false;
            // 
            // _lock4
            // 
            this._lock4.BackColor = System.Drawing.Color.Transparent;
            this._lock4.Location = new System.Drawing.Point(256, 90);
            this._lock4.Name = "_lock4";
            this._lock4.Size = new System.Drawing.Size(20, 20);
            this._lock4.TabIndex = 20;
            this._lock4.TabStop = false;
            // 
            // _lock3
            // 
            this._lock3.Location = new System.Drawing.Point(180, 90);
            this._lock3.Name = "_lock3";
            this._lock3.Size = new System.Drawing.Size(20, 20);
            this._lock3.TabIndex = 19;
            this._lock3.TabStop = false;
            // 
            // _lock2
            // 
            this._lock2.Location = new System.Drawing.Point(105, 90);
            this._lock2.Name = "_lock2";
            this._lock2.Size = new System.Drawing.Size(20, 20);
            this._lock2.TabIndex = 18;
            this._lock2.TabStop = false;
            // 
            // _lock1
            // 
            this._lock1.Location = new System.Drawing.Point(33, 90);
            this._lock1.Name = "_lock1";
            this._lock1.Size = new System.Drawing.Size(20, 20);
            this._lock1.TabIndex = 17;
            this._lock1.TabStop = false;
            // 
            // _dice5
            // 
            this._dice5.Cursor = System.Windows.Forms.Cursors.Hand;
            this._dice5.Image = ((System.Drawing.Image)(resources.GetObject("_dice5.Image")));
            this._dice5.Location = new System.Drawing.Point(306, 16);
            this._dice5.Name = "_dice5";
            this._dice5.Size = new System.Drawing.Size(68, 68);
            this._dice5.TabIndex = 16;
            this._dice5.TabStop = false;
            // 
            // _dice4
            // 
            this._dice4.Cursor = System.Windows.Forms.Cursors.Hand;
            this._dice4.Image = ((System.Drawing.Image)(resources.GetObject("_dice4.Image")));
            this._dice4.Location = new System.Drawing.Point(232, 16);
            this._dice4.Name = "_dice4";
            this._dice4.Size = new System.Drawing.Size(68, 68);
            this._dice4.TabIndex = 15;
            this._dice4.TabStop = false;
            // 
            // _dice1
            // 
            this._dice1.Cursor = System.Windows.Forms.Cursors.Hand;
            this._dice1.Image = ((System.Drawing.Image)(resources.GetObject("_dice1.Image")));
            this._dice1.Location = new System.Drawing.Point(10, 16);
            this._dice1.Name = "_dice1";
            this._dice1.Size = new System.Drawing.Size(68, 68);
            this._dice1.TabIndex = 12;
            this._dice1.TabStop = false;
            // 
            // _dice2
            // 
            this._dice2.Cursor = System.Windows.Forms.Cursors.Hand;
            this._dice2.Image = ((System.Drawing.Image)(resources.GetObject("_dice2.Image")));
            this._dice2.Location = new System.Drawing.Point(84, 16);
            this._dice2.Name = "_dice2";
            this._dice2.Size = new System.Drawing.Size(68, 68);
            this._dice2.TabIndex = 13;
            this._dice2.TabStop = false;
            // 
            // _dice3
            // 
            this._dice3.Cursor = System.Windows.Forms.Cursors.Hand;
            this._dice3.Image = ((System.Drawing.Image)(resources.GetObject("_dice3.Image")));
            this._dice3.Location = new System.Drawing.Point(158, 16);
            this._dice3.Name = "_dice3";
            this._dice3.Size = new System.Drawing.Size(68, 68);
            this._dice3.TabIndex = 14;
            this._dice3.TabStop = false;
            // 
            // _scoreboardPanel
            // 
            this._scoreboardPanel.AutoSize = true;
            this._scoreboardPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._scoreboardPanel.BackColor = System.Drawing.Color.AntiqueWhite;
            this._scoreboardPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this._scoreboardPanel.ColumnCount = 2;
            this._scoreboardPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._scoreboardPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._scoreboardPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._scoreboardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._scoreboardPanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this._scoreboardPanel.Location = new System.Drawing.Point(0, 0);
            this._scoreboardPanel.Name = "_scoreboardPanel";
            this._scoreboardPanel.RowCount = 2;
            this._scoreboardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._scoreboardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._scoreboardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._scoreboardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._scoreboardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._scoreboardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._scoreboardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._scoreboardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._scoreboardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._scoreboardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._scoreboardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._scoreboardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._scoreboardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._scoreboardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._scoreboardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._scoreboardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._scoreboardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._scoreboardPanel.Size = new System.Drawing.Size(711, 512);
            this._scoreboardPanel.TabIndex = 12;
            this._scoreboardPanel.Paint += new System.Windows.Forms.PaintEventHandler(this._scoreboardPanel_Paint);
            // 
            // _sbPanel
            // 
            this._sbPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._sbPanel.Controls.Add(this._scoreboardPanel);
            this._sbPanel.Location = new System.Drawing.Point(11, 12);
            this._sbPanel.Name = "_sbPanel";
            this._sbPanel.Size = new System.Drawing.Size(711, 512);
            this._sbPanel.TabIndex = 13;
            // 
            // _rollButton
            // 
            this._rollButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._rollButton.BackColor = System.Drawing.Color.Transparent;
            this._rollButton.BackgroundImage = global::Yahtzee.Properties.Resources.button;
            this._rollButton.FlatAppearance.BorderSize = 0;
            this._rollButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._rollButton.Location = new System.Drawing.Point(312, 649);
            this._rollButton.Name = "_rollButton";
            this._rollButton.Size = new System.Drawing.Size(120, 50);
            this._rollButton.TabIndex = 5;
            this._rollButton.UseVisualStyleBackColor = false;
            // 
            // _rollsLeft
            // 
            this._rollsLeft.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._rollsLeft.Location = new System.Drawing.Point(438, 649);
            this._rollsLeft.Name = "_rollsLeft";
            this._rollsLeft.Size = new System.Drawing.Size(50, 50);
            this._rollsLeft.TabIndex = 16;
            this._rollsLeft.TabStop = false;
            // 
            // _ffButton
            // 
            this._ffButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._ffButton.Image = global::Yahtzee.Properties.Resources.flag;
            this._ffButton.Location = new System.Drawing.Point(12, 626);
            this._ffButton.Name = "_ffButton";
            this._ffButton.Size = new System.Drawing.Size(74, 73);
            this._ffButton.TabIndex = 17;
            this._ffButton.TabStop = false;
            this._ffButton.Click += new System.EventHandler(this._ffButton_Click);
            // 
            // _soundBox
            // 
            this._soundBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._soundBox.BackColor = System.Drawing.Color.Transparent;
            this._soundBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this._soundBox.Image = global::Yahtzee.Properties.Resources.soundoff_button;
            this._soundBox.Location = new System.Drawing.Point(674, 649);
            this._soundBox.Name = "_soundBox";
            this._soundBox.Size = new System.Drawing.Size(48, 48);
            this._soundBox.TabIndex = 18;
            this._soundBox.TabStop = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(734, 711);
            this.Controls.Add(this._soundBox);
            this.Controls.Add(this._ffButton);
            this.Controls.Add(this._rollsLeft);
            this.Controls.Add(this._sbPanel);
            this.Controls.Add(this._dicePanel);
            this.Controls.Add(this._rollButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(426, 600);
            this.Name = "GameForm";
            this.Text = "Yathzee!";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this._dicePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._lock5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lock4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lock3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lock2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lock1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._dice5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._dice4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._dice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._dice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._dice3)).EndInit();
            this._sbPanel.ResumeLayout(false);
            this._sbPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._rollsLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ffButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._soundBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button _rollButton;
        private System.Windows.Forms.Panel _dicePanel;
        private System.Windows.Forms.PictureBox _dice1;
        private System.Windows.Forms.PictureBox _dice5;
        private System.Windows.Forms.PictureBox _dice4;
        private System.Windows.Forms.PictureBox _dice2;
        private System.Windows.Forms.PictureBox _dice3;
        private System.Windows.Forms.TableLayoutPanel _scoreboardPanel;
        private System.Windows.Forms.Panel _sbPanel;
        private System.Windows.Forms.PictureBox _lock1;
        private System.Windows.Forms.PictureBox _lock5;
        private System.Windows.Forms.PictureBox _lock4;
        private System.Windows.Forms.PictureBox _lock3;
        private System.Windows.Forms.PictureBox _lock2;
        private System.Windows.Forms.PictureBox _rollsLeft;
        private System.Windows.Forms.PictureBox _ffButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox _soundBox;
    }
}