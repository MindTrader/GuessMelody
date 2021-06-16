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
using System.Reflection;

namespace GuessMelody_
{
    public partial class fMessage : Form
    {
        int answerTime = 3;
        public fMessage(string playerName)
        {
            this.Text = playerName;
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            answerTime--;
            lbAnswerTime.Text = answerTime.ToString();

            if (answerTime == 0)
            {
                timer1.Stop();
                SoundPlayer sp = new SoundPlayer("Resources\\crash.wav");
                sp.Play();
            }

        }

        private void fMessage_Load(object sender, EventArgs e)
        {
            lbAnswerTime.Text = answerTime.ToString();
            timer1.Start();
        }

        private void fMessage_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
        }

        private void tbAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Space)
            {
                tbAnswer.Text = GuessMelody.answer;
            }
        }
    }
}
