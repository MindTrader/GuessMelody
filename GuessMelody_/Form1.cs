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
            game.ShowDialog();
        }
    }
}
