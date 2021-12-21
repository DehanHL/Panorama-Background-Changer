using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanoramaVideo
{
    public partial class Form1 : Form
    {
        const string PAN = @"csgo\panorama\videos\";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBDir_Click(object sender, EventArgs e)
        {
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbxDir.Text = fbd.SelectedPath;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbxVid.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
            if (Directory.Exists(@"C:\Program Files (x86)\Steam\steamapps\common\Counter-Strike Global Offensive\"))
            {
                MessageBox.Show("Default csgo directory has been found");
            }
            else
            {
                MessageBox.Show("CSGO is not installed in the default location.\nPlease select the CSGO directory.");
                tbxDir.Text = @"C:\";
            }
        }

        private void btnBVid_Click(object sender, EventArgs e)
        {
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbxVid.Text = ofd.FileName;
            }
        }

        private void btnConf_Click(object sender, EventArgs e)
        {
            if (tbxVid.Text.Contains(".webm"))
            {
                File.Copy(tbxVid.Text, Path.Combine(tbxDir.Text, PAN + "cbble720p.webm"), true);
                File.Copy(tbxVid.Text, Path.Combine(tbxDir.Text, PAN + "cbble540p.webm"), true);
                File.Copy(tbxVid.Text, Path.Combine(tbxDir.Text, PAN + "cbble.webm"), true);
            }
            if (tbxVid.Text.Contains(".mp4"))
            {
                MessageBox.Show("Starting conversion. Please Wait");
                label1.Text = "Converting... Please wait";
                var convert = new NReco.VideoConverter.FFMpegConverter();
                convert.ConvertMedia(tbxVid.Text, Path.Combine(tbxDir.Text, PAN + "convertedmp4.webm"), NReco.VideoConverter.Format.webm);
                File.Copy(Path.Combine(tbxDir.Text, PAN + "convertedmp4.webm"), Path.Combine(tbxDir.Text, PAN + "cbble.webm"), true);
                File.Copy(Path.Combine(tbxDir.Text, PAN + "convertedmp4.webm"), Path.Combine(tbxDir.Text, PAN + "cbble720p.webm"), true);
                File.Copy(Path.Combine(tbxDir.Text, PAN + "convertedmp4.webm"), Path.Combine(tbxDir.Text, PAN + "cbble540p.webm"), true);
            }
            MessageBox.Show("Successfully changed background!\nChange in game bacground to Cobblestone to enable.");
            label1.Text = "";
        }
    }
}
