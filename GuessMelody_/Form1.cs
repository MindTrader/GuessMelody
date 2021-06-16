using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessMelody_
{
    public partial class fMain : Form
    {
        fSettings settings = new fSettings();
        fGame game = new fGame();
        fInstruction faq = new fInstruction();

        public fMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            settings.ShowDialog();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (GuessMelody.songs.Count == 0)
                MessageBox.Show("Не настроена папка с музыкой\n\nПожалуйста, добавьте музыку в настройках и запустите игру заново");
            else
                game.ShowDialog();
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            GuessMelody.ReadParams();

            if (!GuessMelody.instructionWasShown)
            {
                faq.ShowDialog();
            }
        }

        private void btnInstruction_Click(object sender, EventArgs e)
        {
            faq.ShowDialog();
        }
    }
}
