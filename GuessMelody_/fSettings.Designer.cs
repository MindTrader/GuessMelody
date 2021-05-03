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
            this.lbSongs.Size = new System.Drawing.Size(800, 274);
            this.lbSongs.TabIndex = 0;
            // 
            // bSelectFolder
            // 
            this.bSelectFolder.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bSelectFolder.AutoSize = true;
            this.bSelectFolder.Location = new System.Drawing.Point(12, 291);
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
            this.bResetFolder.Location = new System.Drawing.Point(168, 291);
            this.bResetFolder.Name = "bResetFolder";
            this.bResetFolder.Size = new System.Drawing.Size(66, 31);
            this.bResetFolder.TabIndex = 2;
            this.bResetFolder.Text = "Сбросить";
            this.bResetFolder.UseVisualStyleBackColor = true;
            // 
            // cbInnerFolders
            // 
            this.cbInnerFolders.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbInnerFolders.AutoSize = true;
            this.cbInnerFolders.Location = new System.Drawing.Point(571, 299);
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
            this.cbRandomStart.Location = new System.Drawing.Point(12, 343);
            this.cbRandomStart.Name = "cbRandomStart";
            this.cbRandomStart.Size = new System.Drawing.Size(197, 17);
            this.cbRandomStart.TabIndex = 4;
            this.cbRandomStart.Text = "Начать со случайной композиции";
            this.cbRandomStart.UseVisualStyleBackColor = true;
            // 
            // bSave
            // 
            this.bSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bSave.Location = new System.Drawing.Point(298, 391);
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
            this.bCancel.Location = new System.Drawing.Point(409, 391);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 6;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // fSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.cbRandomStart);
            this.Controls.Add(this.cbInnerFolders);
            this.Controls.Add(this.bResetFolder);
            this.Controls.Add(this.bSelectFolder);
            this.Controls.Add(this.lbSongs);
            this.Name = "fSettings";
            this.Text = "Настройки";
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
    }
}