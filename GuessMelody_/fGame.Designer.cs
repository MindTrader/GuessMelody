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
            this.bNextSong = new System.Windows.Forms.Button();
            this.bContinue = new System.Windows.Forms.Button();
            this.lSongsRemains = new System.Windows.Forms.Label();
            this.pbGameDuration = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbPlayer1 = new System.Windows.Forms.TextBox();
            this.tbPlayer2 = new System.Windows.Forms.TextBox();
            this.tbPlayer1Points = new System.Windows.Forms.TextBox();
            this.tbPlayer2Points = new System.Windows.Forms.TextBox();
            this.btnPlayer1PointsMore = new System.Windows.Forms.Button();
            this.btnPlayer1PointsLess = new System.Windows.Forms.Button();
            this.btnPlayer2PointsMore = new System.Windows.Forms.Button();
            this.btnPlayer2PointsLess = new System.Windows.Forms.Button();
            this.tbSongDuration = new System.Windows.Forms.TextBox();
            this.tbPlayer1Ready = new System.Windows.Forms.TextBox();
            this.tbPlayer2Ready = new System.Windows.Forms.TextBox();
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
            this.bPause.Location = new System.Drawing.Point(389, 376);
            this.bPause.Name = "bPause";
            this.bPause.Size = new System.Drawing.Size(75, 65);
            this.bPause.TabIndex = 1;
            this.bPause.TabStop = false;
            this.bPause.Text = "Пауза";
            this.bPause.UseVisualStyleBackColor = true;
            this.bPause.Click += new System.EventHandler(this.bPause_Click);
            // 
            // bNextSong
            // 
            this.bNextSong.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bNextSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bNextSong.Location = new System.Drawing.Point(389, 451);
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
            this.bContinue.Location = new System.Drawing.Point(470, 376);
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
            // tbPlayer1
            // 
            this.tbPlayer1.Enabled = false;
            this.tbPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPlayer1.Location = new System.Drawing.Point(157, 46);
            this.tbPlayer1.Name = "tbPlayer1";
            this.tbPlayer1.ReadOnly = true;
            this.tbPlayer1.Size = new System.Drawing.Size(171, 36);
            this.tbPlayer1.TabIndex = 12;
            this.tbPlayer1.Text = "Игрок 1";
            this.tbPlayer1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPlayer2
            // 
            this.tbPlayer2.Enabled = false;
            this.tbPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPlayer2.Location = new System.Drawing.Point(658, 46);
            this.tbPlayer2.Name = "tbPlayer2";
            this.tbPlayer2.ReadOnly = true;
            this.tbPlayer2.Size = new System.Drawing.Size(171, 36);
            this.tbPlayer2.TabIndex = 13;
            this.tbPlayer2.Text = "Игрок 2";
            this.tbPlayer2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPlayer1Points
            // 
            this.tbPlayer1Points.Enabled = false;
            this.tbPlayer1Points.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPlayer1Points.Location = new System.Drawing.Point(206, 97);
            this.tbPlayer1Points.Name = "tbPlayer1Points";
            this.tbPlayer1Points.ReadOnly = true;
            this.tbPlayer1Points.Size = new System.Drawing.Size(75, 40);
            this.tbPlayer1Points.TabIndex = 14;
            this.tbPlayer1Points.Text = "0";
            this.tbPlayer1Points.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPlayer2Points
            // 
            this.tbPlayer2Points.Enabled = false;
            this.tbPlayer2Points.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPlayer2Points.Location = new System.Drawing.Point(706, 97);
            this.tbPlayer2Points.Name = "tbPlayer2Points";
            this.tbPlayer2Points.ReadOnly = true;
            this.tbPlayer2Points.Size = new System.Drawing.Size(75, 40);
            this.tbPlayer2Points.TabIndex = 15;
            this.tbPlayer2Points.Text = "0";
            this.tbPlayer2Points.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPlayer1PointsMore
            // 
            this.btnPlayer1PointsMore.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPlayer1PointsMore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlayer1PointsMore.Location = new System.Drawing.Point(157, 96);
            this.btnPlayer1PointsMore.Name = "btnPlayer1PointsMore";
            this.btnPlayer1PointsMore.Size = new System.Drawing.Size(34, 40);
            this.btnPlayer1PointsMore.TabIndex = 19;
            this.btnPlayer1PointsMore.TabStop = false;
            this.btnPlayer1PointsMore.Text = "+";
            this.btnPlayer1PointsMore.UseVisualStyleBackColor = true;
            this.btnPlayer1PointsMore.Click += new System.EventHandler(this.lbPlayerPointsMore_Click);
            // 
            // btnPlayer1PointsLess
            // 
            this.btnPlayer1PointsLess.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPlayer1PointsLess.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlayer1PointsLess.Location = new System.Drawing.Point(294, 96);
            this.btnPlayer1PointsLess.Name = "btnPlayer1PointsLess";
            this.btnPlayer1PointsLess.Size = new System.Drawing.Size(34, 40);
            this.btnPlayer1PointsLess.TabIndex = 20;
            this.btnPlayer1PointsLess.TabStop = false;
            this.btnPlayer1PointsLess.Text = "-";
            this.btnPlayer1PointsLess.UseVisualStyleBackColor = true;
            this.btnPlayer1PointsLess.Click += new System.EventHandler(this.lbPlayerPointsLess_Click);
            // 
            // btnPlayer2PointsMore
            // 
            this.btnPlayer2PointsMore.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPlayer2PointsMore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlayer2PointsMore.Location = new System.Drawing.Point(658, 97);
            this.btnPlayer2PointsMore.Name = "btnPlayer2PointsMore";
            this.btnPlayer2PointsMore.Size = new System.Drawing.Size(34, 40);
            this.btnPlayer2PointsMore.TabIndex = 21;
            this.btnPlayer2PointsMore.TabStop = false;
            this.btnPlayer2PointsMore.Text = "+";
            this.btnPlayer2PointsMore.UseVisualStyleBackColor = true;
            this.btnPlayer2PointsMore.Click += new System.EventHandler(this.lbPlayerPointsMore_Click);
            // 
            // btnPlayer2PointsLess
            // 
            this.btnPlayer2PointsLess.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPlayer2PointsLess.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlayer2PointsLess.Location = new System.Drawing.Point(795, 96);
            this.btnPlayer2PointsLess.Name = "btnPlayer2PointsLess";
            this.btnPlayer2PointsLess.Size = new System.Drawing.Size(34, 40);
            this.btnPlayer2PointsLess.TabIndex = 22;
            this.btnPlayer2PointsLess.TabStop = false;
            this.btnPlayer2PointsLess.Text = "-";
            this.btnPlayer2PointsLess.UseVisualStyleBackColor = true;
            this.btnPlayer2PointsLess.Click += new System.EventHandler(this.lbPlayerPointsLess_Click);
            // 
            // tbSongDuration
            // 
            this.tbSongDuration.Enabled = false;
            this.tbSongDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSongDuration.Location = new System.Drawing.Point(455, 224);
            this.tbSongDuration.Name = "tbSongDuration";
            this.tbSongDuration.ReadOnly = true;
            this.tbSongDuration.Size = new System.Drawing.Size(75, 40);
            this.tbSongDuration.TabIndex = 23;
            this.tbSongDuration.Text = "0";
            this.tbSongDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPlayer1Ready
            // 
            this.tbPlayer1Ready.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tbPlayer1Ready.Enabled = false;
            this.tbPlayer1Ready.ForeColor = System.Drawing.Color.Lime;
            this.tbPlayer1Ready.Location = new System.Drawing.Point(114, 46);
            this.tbPlayer1Ready.Multiline = true;
            this.tbPlayer1Ready.Name = "tbPlayer1Ready";
            this.tbPlayer1Ready.ReadOnly = true;
            this.tbPlayer1Ready.Size = new System.Drawing.Size(36, 36);
            this.tbPlayer1Ready.TabIndex = 24;
            this.tbPlayer1Ready.TabStop = false;
            // 
            // tbPlayer2Ready
            // 
            this.tbPlayer2Ready.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tbPlayer2Ready.Enabled = false;
            this.tbPlayer2Ready.Location = new System.Drawing.Point(835, 46);
            this.tbPlayer2Ready.Multiline = true;
            this.tbPlayer2Ready.Name = "tbPlayer2Ready";
            this.tbPlayer2Ready.ReadOnly = true;
            this.tbPlayer2Ready.Size = new System.Drawing.Size(36, 36);
            this.tbPlayer2Ready.TabIndex = 25;
            this.tbPlayer2Ready.TabStop = false;
            // 
            // fGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GuessMelody_.Properties.Resources._0f1872ae8eef2e9e06c32d0e30277ac2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(975, 595);
            this.Controls.Add(this.tbPlayer2Ready);
            this.Controls.Add(this.tbPlayer1Ready);
            this.Controls.Add(this.tbSongDuration);
            this.Controls.Add(this.btnPlayer2PointsLess);
            this.Controls.Add(this.btnPlayer2PointsMore);
            this.Controls.Add(this.btnPlayer1PointsLess);
            this.Controls.Add(this.btnPlayer1PointsMore);
            this.Controls.Add(this.tbPlayer2Points);
            this.Controls.Add(this.tbPlayer1Points);
            this.Controls.Add(this.tbPlayer2);
            this.Controls.Add(this.tbPlayer1);
            this.Controls.Add(this.pbGameDuration);
            this.Controls.Add(this.lSongsRemains);
            this.Controls.Add(this.bContinue);
            this.Controls.Add(this.bNextSong);
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
        private System.Windows.Forms.Button bNextSong;
        private System.Windows.Forms.Button bContinue;
        private System.Windows.Forms.Label lSongsRemains;
        private System.Windows.Forms.ProgressBar pbGameDuration;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox tbPlayer1;
        private System.Windows.Forms.TextBox tbPlayer2;
        private System.Windows.Forms.TextBox tbPlayer1Points;
        private System.Windows.Forms.TextBox tbPlayer2Points;
        private System.Windows.Forms.Button btnPlayer1PointsMore;
        private System.Windows.Forms.Button btnPlayer1PointsLess;
        private System.Windows.Forms.Button btnPlayer2PointsMore;
        private System.Windows.Forms.Button btnPlayer2PointsLess;
        private System.Windows.Forms.TextBox tbSongDuration;
        private System.Windows.Forms.TextBox tbPlayer1Ready;
        private System.Windows.Forms.TextBox tbPlayer2Ready;
    }
}