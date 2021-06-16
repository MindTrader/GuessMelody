using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace GuessMelody_
{
    public partial class fGame : Form
    {
        Random random = new Random();

        int songDuration;
        int successfulAnswersPl1 = 0;
        int successfulAnswersPl2 = 0;

        bool player1Answered = false, player2Answered = false;

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
            if (!string.IsNullOrEmpty(WMP.URL))
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

            tbPlayer1.Text = GuessMelody.player1Name;
            tbPlayer2.Text = GuessMelody.player2Name;

            tbSongDuration.Text = GuessMelody.songDuration.ToString();

            MakeMusic();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pbGameDuration.Value == pbGameDuration.Maximum)
            {
                StopGame();
                MessageBox.Show("Время вышло. Игра завершена");
            }
            else
            {
                pbGameDuration.Value++;
                songDuration--;
                tbSongDuration.Text = songDuration.ToString();
            }
            if (songDuration == 0)
                MakeMusic();
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
                songDuration = GuessMelody.songDuration;

                timer1.Start();

                int n = random.Next(0, GuessMelody.songs.Count);
                WMP.URL = GuessMelody.songs[n];
                GuessMelody.songs.RemoveAt(n);

                lSongsRemains.Text = "" + GuessMelody.songs.Count;
                tbSongDuration.Text = "" + GuessMelody.songDuration;

                GuessMelody.answer = System.IO.Path.GetFileNameWithoutExtension(WMP.URL);
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
            try
            {
                if (timer1.Enabled)
                    if (e.KeyData == (Keys)Enum.Parse(typeof(Keys), GuessMelody.player1AnswerKey.ToUpperInvariant()))
                    {
                        if (!player1Answered)
                        {
                            if (GuessMelody.voicePlayerName)
                            {
                                SoundPlayer sp = new SoundPlayer("..\\..\\Resources\\firstPlayer.wav");
                                sp.Play();
                            }
                            player1Answered = true;
                            SetPoints(GuessMelody.player1Name, tbPlayer1Points);
                        }
                    }
                    else if (e.KeyData == (Keys)Enum.Parse(typeof(Keys), GuessMelody.player2AnswerKey.ToUpperInvariant()))
                    {
                        if (!player2Answered)
                        {
                            if (GuessMelody.voicePlayerName)
                            {
                                SoundPlayer sp = new SoundPlayer("..\\..\\Resources\\secondPlayer.wav");
                                sp.Play();
                            }
                            player2Answered = true;
                            SetPoints(GuessMelody.player2Name, tbPlayer2Points);
                        }
                    }

                if (player1Answered && player2Answered)
                {
                    player1Answered = false;
                    player2Answered = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка настройки горячих клавиш. Измените значение в настройках и повторите. \n\n" + ex.Message);
            }
        }

        private void SetPoints(string playerName, TextBox points)
        {
            fMessage mes = new fMessage(playerName);

            PauseGame();
            if (mes.ShowDialog() == DialogResult.Yes)
            {
                int pointsNum = Convert.ToInt32(points.Text);

                points.Text = (++pointsNum).ToString();

                if (GuessMelody.bonusForAnswers)
                {
                    if (playerName == GuessMelody.player1Name)
                    {
                        successfulAnswersPl1++;
                        successfulAnswersPl2 = 0;
                    }
                    else
                    {
                        successfulAnswersPl2++;
                        successfulAnswersPl1 = 0;
                    }

                    if (successfulAnswersPl1 == 3 || successfulAnswersPl2 == 3)
                    {
                        points.Text = (pointsNum + 2).ToString();

                        successfulAnswersPl1 = 0;
                        successfulAnswersPl2 = 0;
                    }
                }

                MakeMusic();

                player1Answered = false;
                player2Answered = false;
            }
            else
            {
                if (playerName == GuessMelody.player1Name)
                    successfulAnswersPl1 = 0;
                else
                    successfulAnswersPl2 = 0;

                ContinueGame();
            }
        }

        private void lbPlayerPointsMore_Click(object sender, EventArgs e)
        {
            Button btnPlayerPoints = sender as Button;

            if (btnPlayerPoints.Name.Contains("Player1"))
                tbPlayer1Points.Text = (Convert.ToInt32(tbPlayer1Points.Text) + 1).ToString();
            else
                tbPlayer2Points.Text = (Convert.ToInt32(tbPlayer2Points.Text) + 1).ToString();
        }

        private void lbPlayerPointsLess_Click(object sender, EventArgs e)
        {
            Button btnPlayerPoints = sender as Button;

            if (btnPlayerPoints.Name.Contains("Player1"))
            {
                if (Convert.ToInt32(tbPlayer1Points.Text) > 0)
                    tbPlayer1Points.Text = (Convert.ToInt32(tbPlayer1Points.Text) - 1).ToString();
            }
            else
            {
                if (Convert.ToInt32(tbPlayer2Points.Text) > 0)
                    tbPlayer2Points.Text = (Convert.ToInt32(tbPlayer2Points.Text) - 1).ToString();
            }
        }

        private void WMP_OpenStateChange(object sender, AxWMPLib._WMPOCXEvents_OpenStateChangeEvent e)
        {
            if (GuessMelody.randomStart)
                if (WMP.openState == WMPLib.WMPOpenState.wmposMediaOpen)
                    WMP.Ctlcontrols.currentPosition = random.Next(0, (int)WMP.currentMedia.duration / 2);
        }
    }
}
