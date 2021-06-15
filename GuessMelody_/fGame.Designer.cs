namespace GuessMelody_
{
    partial class fGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fGame));
            this.WMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.bPause = new System.Windows.Forms.Button();
            this.lbPlayer1 = new System.Windows.Forms.Label();
            this.lPlayer2Points = new System.Windows.Forms.Label();
            this.lPlayer1Points = new System.Windows.Forms.Label();
            this.lbPlayer2 = new System.Windows.Forms.Label();
            this.bNextSong = new System.Windows.Forms.Button();
            this.bContinue = new System.Windows.Forms.Button();
            this.lSongsRemains = new System.Windows.Forms.Label();
            this.pbGameDuration = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbSongDuration = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).BeginInit();
            this.SuspendLayout();
            // 
            // WMP
            // 
            this.WMP.Enabled = true;
            this.WMP.Location = new System.Drawing.Point(12, 560);
            this.WMP.Name = "WMP";
            this.WMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP.OcxState")));
            this.WMP.Size = new System.Drawing.Size(75, 23);
            this.WMP.TabIndex = 0;
            this.WMP.Visible = false;
            this.WMP.OpenStateChange += new AxWMPLib._WMPOCXEvents_OpenStateChangeEventHandler(this.WMP_OpenStateChange);
            // 
            // bPause
            // 
            this.bPause.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bPause.Location = new System.Drawing.Point(375, 363);
            this.bPause.Name = "bPause";
            this.bPause.Size = new System.Drawing.Size(75, 65);
            this.bPause.TabIndex = 1;
            this.bPause.TabStop = false;
            this.bPause.Text = "Пауза";
            this.bPause.UseVisualStyleBackColor = true;
            this.bPause.Click += new System.EventHandler(this.bPause_Click);
            // 
            // lbPlayer1
            // 
            this.lbPlayer1.AutoSize = true;
            this.lbPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPlayer1.Location = new System.Drawing.Point(183, 56);
            this.lbPlayer1.Name = "lbPlayer1";
            this.lbPlayer1.Size = new System.Drawing.Size(110, 31);
            this.lbPlayer1.TabIndex = 2;
            this.lbPlayer1.Text = "Игрок 1";
            // 
            // lPlayer2Points
            // 
            this.lPlayer2Points.AutoSize = true;
            this.lPlayer2Points.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lPlayer2Points.Location = new System.Drawing.Point(724, 105);
            this.lPlayer2Points.Name = "lPlayer2Points";
            this.lPlayer2Points.Size = new System.Drawing.Size(29, 31);
            this.lPlayer2Points.TabIndex = 3;
            this.lPlayer2Points.Text = "0";
            this.lPlayer2Points.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lPlayerPoints_MouseClick);
            // 
            // lPlayer1Points
            // 
            this.lPlayer1Points.AutoSize = true;
            this.lPlayer1Points.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lPlayer1Points.Location = new System.Drawing.Point(222, 105);
            this.lPlayer1Points.Name = "lPlayer1Points";
            this.lPlayer1Points.Size = new System.Drawing.Size(29, 31);
            this.lPlayer1Points.TabIndex = 4;
            this.lPlayer1Points.Text = "0";
            this.lPlayer1Points.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lPlayerPoints_MouseClick);
            // 
            // lbPlayer2
            // 
            this.lbPlayer2.AutoSize = true;
            this.lbPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPlayer2.Location = new System.Drawing.Point(685, 56);
            this.lbPlayer2.Name = "lbPlayer2";
            this.lbPlayer2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbPlayer2.Size = new System.Drawing.Size(110, 31);
            this.lbPlayer2.TabIndex = 5;
            this.lbPlayer2.Text = "Игрок 2";
            // 
            // bNextSong
            // 
            this.bNextSong.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bNextSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bNextSong.Location = new System.Drawing.Point(375, 451);
            this.bNextSong.Name = "bNextSong";
            this.bNextSong.Size = new System.Drawing.Size(206, 65);
            this.bNextSong.TabIndex = 6;
            this.bNextSong.Text = "Следующая композиция";
            this.bNextSong.UseVisualStyleBackColor = true;
            this.bNextSong.Click += new System.EventHandler(this.bNextSong_Click);
            // 
            // bContinue
            // 
            this.bContinue.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bContinue.Location = new System.Drawing.Point(456, 363);
            this.bContinue.Name = "bContinue";
            this.bContinue.Size = new System.Drawing.Size(125, 65);
            this.bContinue.TabIndex = 8;
            this.bContinue.TabStop = false;
            this.bContinue.Text = "Продолжить";
            this.bContinue.UseVisualStyleBackColor = true;
            this.bContinue.Click += new System.EventHandler(this.bContinue_Click);
            // 
            // lSongsRemains
            // 
            this.lSongsRemains.AutoSize = true;
            this.lSongsRemains.Enabled = false;
            this.lSongsRemains.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lSongsRemains.Location = new System.Drawing.Point(7, 561);
            this.lSongsRemains.Name = "lSongsRemains";
            this.lSongsRemains.Size = new System.Drawing.Size(64, 25);
            this.lSongsRemains.TabIndex = 9;
            this.lSongsRemains.Text = "label5";
            // 
            // pbGameDuration
            // 
            this.pbGameDuration.Location = new System.Drawing.Point(77, 287);
            this.pbGameDuration.Name = "pbGameDuration";
            this.pbGameDuration.Size = new System.Drawing.Size(832, 35);
            this.pbGameDuration.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbGameDuration.TabIndex = 10;
            this.pbGameDuration.Value = 50;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbSongDuration
            // 
            this.lbSongDuration.AutoSize = true;
            this.lbSongDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSongDuration.Location = new System.Drawing.Point(475, 198);
            this.lbSongDuration.Name = "lbSongDuration";
            this.lbSongDuration.Size = new System.Drawing.Size(31, 33);
            this.lbSongDuration.TabIndex = 11;
            this.lbSongDuration.Text = "0";
            // 
            // fGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GuessMelody_.Properties.Resources._0f1872ae8eef2e9e06c32d0e30277ac2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(975, 595);
            this.Controls.Add(this.lbSongDuration);
            this.Controls.Add(this.pbGameDuration);
            this.Controls.Add(this.lSongsRemains);
            this.Controls.Add(this.bContinue);
            this.Controls.Add(this.bNextSong);
            this.Controls.Add(this.lbPlayer2);
            this.Controls.Add(this.lPlayer1Points);
            this.Controls.Add(this.lPlayer2Points);
            this.Controls.Add(this.lbPlayer1);
            this.Controls.Add(this.bPause);
            this.Controls.Add(this.WMP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "fGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Игра";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fGame_FormClosed);
            this.Load += new System.EventHandler(this.fGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fGame_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer WMP;
        private System.Windows.Forms.Button bPause;
        private System.Windows.Forms.Label lbPlayer1;
        private System.Windows.Forms.Label lPlayer2Points;
        private System.Windows.Forms.Label lPlayer1Points;
        private System.Windows.Forms.Label lbPlayer2;
        private System.Windows.Forms.Button bNextSong;
        private System.Windows.Forms.Button bContinue;
        private System.Windows.Forms.Label lSongsRemains;
        private System.Windows.Forms.ProgressBar pbGameDuration;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbSongDuration;
    }
}