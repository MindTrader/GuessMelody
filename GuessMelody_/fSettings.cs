using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessMelody_
{
    public partial class fSettings : Form
    {
        public fSettings()
        {
            InitializeComponent();
        }

        private void bSelectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string[] musicList = Directory.GetFiles(fbd.SelectedPath, "*.mp3", cbInnerFolders.Checked ? System.IO.SearchOption.AllDirectories : System.IO.SearchOption.TopDirectoryOnly);

                lbSongs.Items.Clear();
                lbSongs.Items.AddRange(musicList);

                GuessMelody.lastFolder = fbd.SelectedPath;
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            GuessMelody.gameDuration = int.Parse(cbGameDuration.Text);
            GuessMelody.songDuration = int.Parse(cbSongDuration.Text);

            GuessMelody.player1Name = tbPlayer1.Text;
            GuessMelody.player2Name = tbPlayer2.Text;
            GuessMelody.player1AnswerKey = cbKeyPlayer1.Text;
            GuessMelody.player2AnswerKey = cbKeyPlayer2.Text;

            GuessMelody.randomStart = cbRandomStart.Checked;
            GuessMelody.scanInnerDirectories = cbInnerFolders.Checked;
            GuessMelody.voicePlayerName = cbPlayerNameVoice.Checked;
            GuessMelody.bonusForAnswers = cbBonusForAnswers.Checked;

            GuessMelody.songs.Clear();
            GuessMelody.songs.AddRange(lbSongs.Items.Cast<string>());

            GuessMelody.WriteParams();

            this.Hide();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void fSettings_Load(object sender, EventArgs e)
        {
            SetParamsPage();
        }

        private void bResetFolder_Click(object sender, EventArgs e)
        {
            GuessMelody.lastFolder = "";
            lbSongs.Items.Clear();
        }

        private void SetParamsPage()
        {
            cbGameDuration.Text = Convert.ToString(GuessMelody.gameDuration);
            cbSongDuration.Text = Convert.ToString(GuessMelody.songDuration);

            cbKeyPlayer1.Text = GuessMelody.player1AnswerKey;
            cbKeyPlayer2.Text = GuessMelody.player2AnswerKey;
            tbPlayer1.Text = GuessMelody.player1Name;
            tbPlayer2.Text = GuessMelody.player2Name;

            cbRandomStart.Checked = GuessMelody.randomStart;
            cbInnerFolders.Checked = GuessMelody.scanInnerDirectories;
            cbPlayerNameVoice.Checked = GuessMelody.voicePlayerName;
            cbBonusForAnswers.Checked = GuessMelody.bonusForAnswers;

            lbSongs.Items.Clear();
            lbSongs.Items.AddRange(GuessMelody.songs.ToArray());
        }
    }
}
