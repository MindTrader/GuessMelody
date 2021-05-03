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
                string[] musicList = Directory.GetFiles(fbd.SelectedPath, "*.mp3", cbInnerFolders.Checked ? System.IO.SearchOption.AllDirectories : System.IO.SearchOption.TopDirectoryOnly).Select(p => Path.GetFileNameWithoutExtension(p)).ToArray();

                lbSongs.Items.Clear();
                lbSongs.Items.AddRange(musicList);
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
