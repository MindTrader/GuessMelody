using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessMelody_
{
    public partial class fGame : Form
    {
        Random random = new Random();
        public fGame()
        {
            InitializeComponent();
        }

        private void bNextSong_Click(object sender, EventArgs e)
        {
            MakeMusic();
        }

        private void fGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            StopGame();
        }

        private void bContinue_Click(object sender, EventArgs e)
        {
            ContinueGame();
        }

        private void bPause_Click(object sender, EventArgs e)
        {
            PauseGame();
        }

        private void fGame_Load(object sender, EventArgs e)
        {
            lSongsRemains.Text = "Осталось непроигранных песен: " + GuessMelody.songs.Count;

            pbGameDuration.Value = 0;
            pbGameDuration.Maximum = GuessMelody.gameDuration;

            lbPlayer1.Text = GuessMelody.player1Name;
            lbPlayer2.Text = GuessMelody.player2Name;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pbGameDuration.Value == pbGameDuration.Maximum)
                StopGame();
            else
                pbGameDuration.Value++;
        }

        private void MakeMusic()
        {
            if (GuessMelody.songs.Count == 0)
            {
                MessageBox.Show("Вы прослушали все песни\n\nВыберите другую папку с музыкой, иначе вы продолжите прослушивание прошлых треков");
                GuessMelody.ReadMusic();
                StopGame();
            }
            else
            {
                timer1.Start();

                int n = random.Next(0, GuessMelody.songs.Count);
                WMP.URL = GuessMelody.songs[n];
                GuessMelody.songs.RemoveAt(n);

                lSongsRemains.Text = "" + GuessMelody.songs.Count;
            }
        }

        private void PauseGame()
        {
            WMP.Ctlcontrols.pause();
            timer1.Stop();
        }

        private void ContinueGame()
        {
            WMP.Ctlcontrols.play();
            timer1.Start();
        }

        private void StopGame()
        {
            WMP.Ctlcontrols.stop();
            timer1.Stop();
        }

        private void fGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys)Enum.Parse(typeof(Keys), GuessMelody.player1AnswerKey))
                SetPoints(GuessMelody.player1Name, lPlayer1Points);
            else if (e.KeyData == (Keys)Enum.Parse(typeof(Keys), GuessMelody.player2AnswerKey))
                SetPoints(GuessMelody.player2Name, lPlayer2Points);
        }

        private void SetPoints(string playerName, Label points)
        {
            fMessage mes = new fMessage(playerName);

            PauseGame();
            if (mes.ShowDialog() == DialogResult.Yes)
            {
                points.Text = (Convert.ToInt32(points.Text) + 1).ToString();
                MakeMusic();
            }
            else
                ContinueGame();
        }

        private void WMP_OpenStateChange(object sender, AxWMPLib._WMPOCXEvents_OpenStateChangeEvent e)
        {
            if (GuessMelody.randomStart)
                if (WMP.openState == WMPLib.WMPOpenState.wmposMediaOpen)
                    WMP.Ctlcontrols.currentPosition = random.Next(0, (int)WMP.currentMedia.duration / 2);
        }
    }
}
