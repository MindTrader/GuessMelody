using System.Windows.Forms;

namespace GuessMelody_
{
    partial class fSettings
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
            this.lbSongs = new System.Windows.Forms.ListBox();
            this.bSelectFolder = new System.Windows.Forms.Button();
            this.bResetFolder = new System.Windows.Forms.Button();
            this.cbInnerFolders = new System.Windows.Forms.CheckBox();
            this.cbRandomStart = new System.Windows.Forms.CheckBox();
            this.bSave = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbGameDuration = new System.Windows.Forms.ComboBox();
            this.cbSongDuration = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPlayer1 = new System.Windows.Forms.TextBox();
            this.tbPlayer2 = new System.Windows.Forms.TextBox();
            this.cbKeyPlayer1 = new System.Windows.Forms.ComboBox();
            this.cbKeyPlayer2 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbSongs
            // 
            this.lbSongs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSongs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSongs.FormattingEnabled = true;
            this.lbSongs.ItemHeight = 18;
            this.lbSongs.Location = new System.Drawing.Point(0, 0);
            this.lbSongs.Name = "lbSongs";
            this.lbSongs.Size = new System.Drawing.Size(701, 310);
            this.lbSongs.TabIndex = 0;
            // 
            // bSelectFolder
            // 
            this.bSelectFolder.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bSelectFolder.AutoSize = true;
            this.bSelectFolder.Location = new System.Drawing.Point(10, 340);
            this.bSelectFolder.Name = "bSelectFolder";
            this.bSelectFolder.Size = new System.Drawing.Size(122, 31);
            this.bSelectFolder.TabIndex = 1;
            this.bSelectFolder.Text = "Выбрать папку";
            this.bSelectFolder.UseVisualStyleBackColor = true;
            this.bSelectFolder.Click += new System.EventHandler(this.bSelectFolder_Click);
            // 
            // bResetFolder
            // 
            this.bResetFolder.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bResetFolder.Location = new System.Drawing.Point(144, 340);
            this.bResetFolder.Name = "bResetFolder";
            this.bResetFolder.Size = new System.Drawing.Size(66, 31);
            this.bResetFolder.TabIndex = 2;
            this.bResetFolder.Text = "Сбросить";
            this.bResetFolder.UseVisualStyleBackColor = true;
            this.bResetFolder.Click += new System.EventHandler(this.bResetFolder_Click);
            // 
            // cbInnerFolders
            // 
            this.cbInnerFolders.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbInnerFolders.AutoSize = true;
            this.cbInnerFolders.Location = new System.Drawing.Point(10, 316);
            this.cbInnerFolders.Name = "cbInnerFolders";
            this.cbInnerFolders.Size = new System.Drawing.Size(176, 17);
            this.cbInnerFolders.TabIndex = 3;
            this.cbInnerFolders.Text = "Искать во внутренних папках";
            this.cbInnerFolders.UseVisualStyleBackColor = true;
            // 
            // cbRandomStart
            // 
            this.cbRandomStart.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbRandomStart.AutoSize = true;
            this.cbRandomStart.Location = new System.Drawing.Point(433, 433);
            this.cbRandomStart.Name = "cbRandomStart";
            this.cbRandomStart.Size = new System.Drawing.Size(171, 17);
            this.cbRandomStart.TabIndex = 4;
            this.cbRandomStart.Text = "Начать со случайного места";
            this.cbRandomStart.UseVisualStyleBackColor = true;
            // 
            // bSave
            // 
            this.bSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bSave.Location = new System.Drawing.Point(251, 457);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 23);
            this.bSave.TabIndex = 5;
            this.bSave.Text = "Сохранить";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bCancel
            // 
            this.bCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bCancel.Location = new System.Drawing.Point(343, 457);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 6;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbGameDuration);
            this.groupBox1.Controls.Add(this.cbSongDuration);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(424, 327);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки времени";
            // 
            // cbGameDuration
            // 
            this.cbGameDuration.FormattingEnabled = true;
            this.cbGameDuration.Items.AddRange(new object[] {
            "30",
            "60",
            "90",
            "180",
            "360",
            "600"});
            this.cbGameDuration.Location = new System.Drawing.Point(187, 56);
            this.cbGameDuration.Name = "cbGameDuration";
            this.cbGameDuration.Size = new System.Drawing.Size(54, 21);
            this.cbGameDuration.TabIndex = 3;
            this.cbGameDuration.Text = "60";
            // 
            // cbSongDuration
            // 
            this.cbSongDuration.FormattingEnabled = true;
            this.cbSongDuration.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30"});
            this.cbSongDuration.Location = new System.Drawing.Point(187, 25);
            this.cbSongDuration.Name = "cbSongDuration";
            this.cbSongDuration.Size = new System.Drawing.Size(54, 21);
            this.cbSongDuration.TabIndex = 2;
            this.cbSongDuration.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Продолжительность игры (с)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Продолжительность песни (с)";
            // 
            // tbPlayer1
            // 
            this.tbPlayer1.Location = new System.Drawing.Point(6, 16);
            this.tbPlayer1.Name = "tbPlayer1";
            this.tbPlayer1.Size = new System.Drawing.Size(100, 20);
            this.tbPlayer1.TabIndex = 8;
            this.tbPlayer1.Text = "Игрок 1";
            // 
            // tbPlayer2
            // 
            this.tbPlayer2.Location = new System.Drawing.Point(6, 39);
            this.tbPlayer2.Name = "tbPlayer2";
            this.tbPlayer2.Size = new System.Drawing.Size(100, 20);
            this.tbPlayer2.TabIndex = 9;
            this.tbPlayer2.Text = "Игрок 2";
            // 
            // cbKeyPlayer1
            // 
            this.cbKeyPlayer1.FormattingEnabled = true;
            this.cbKeyPlayer1.Items.AddRange(new object[] {
            "A",
            "Q",
            "Z",
            "W",
            "S",
            "X"});
            this.cbKeyPlayer1.Location = new System.Drawing.Point(128, 16);
            this.cbKeyPlayer1.Name = "cbKeyPlayer1";
            this.cbKeyPlayer1.Size = new System.Drawing.Size(54, 21);
            this.cbKeyPlayer1.TabIndex = 4;
            this.cbKeyPlayer1.Text = "A";
            // 
            // cbKeyPlayer2
            // 
            this.cbKeyPlayer2.FormattingEnabled = true;
            this.cbKeyPlayer2.Items.AddRange(new object[] {
            "O",
            "K",
            "M",
            "P",
            "L",
            "<"});
            this.cbKeyPlayer2.Location = new System.Drawing.Point(128, 39);
            this.cbKeyPlayer2.Name = "cbKeyPlayer2";
            this.cbKeyPlayer2.Size = new System.Drawing.Size(54, 21);
            this.cbKeyPlayer2.TabIndex = 10;
            this.cbKeyPlayer2.Text = "L";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbPlayer1);
            this.groupBox2.Controls.Add(this.cbKeyPlayer2);
            this.groupBox2.Controls.Add(this.tbPlayer2);
            this.groupBox2.Controls.Add(this.cbKeyPlayer1);
            this.groupBox2.Location = new System.Drawing.Point(10, 383);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 67);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Клавиши для ответа";
            // 
            // fSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 486);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.cbRandomStart);
            this.Controls.Add(this.cbInnerFolders);
            this.Controls.Add(this.bResetFolder);
            this.Controls.Add(this.bSelectFolder);
            this.Controls.Add(this.lbSongs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "fSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.fSettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbSongs;
        private System.Windows.Forms.Button bSelectFolder;
        private System.Windows.Forms.Button bResetFolder;
        private System.Windows.Forms.CheckBox cbInnerFolders;
        private System.Windows.Forms.CheckBox cbRandomStart;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bCancel;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private ComboBox cbGameDuration;
        private ComboBox cbSongDuration;
        private TextBox tbPlayer1;
        private TextBox tbPlayer2;
        private ComboBox cbKeyPlayer1;
        private ComboBox cbKeyPlayer2;
        private GroupBox groupBox2;
    }
}