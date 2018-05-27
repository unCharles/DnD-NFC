using System;
using System.Drawing;
using System.Windows.Forms;

namespace DnD_NFC
{
    public partial class DisplayWindow : Form
    {
        private Character character;

        public DisplayWindow()
        {
            InitializeComponent();
        }

        public void InitializeVideoPlayer()
        {
            videoPlayer.Enabled = false;
            videoPlayer.Visible = false;
        }

        public void DisplayCharacter(int id)
        {
            pictureBox.Hide();
            InitializeCharacter(id);
        }

        public void InitializeCharacter(int id)
        {
            character = Character.Find(id);
        }

        public void SetMonitor(int monitor)
        {
            if (monitor > Screen.AllScreens.Length - 1)
            {
                monitor = 0;
            }
            var screen = Screen.AllScreens[monitor];

            StartPosition = FormStartPosition.Manual;
            Location = screen.WorkingArea.Location;
            FormBorderStyle = FormBorderStyle.None;
            Size = new Size(screen.WorkingArea.Width, screen.WorkingArea.Height);
        }

        public void DisplayImage(string image)
        {
            character = null;
            if (image != null)
            {
                if (IsVideoFile(image))
                {
                    videoPlayer.URL = image;
                    videoPlayer.Enabled = true;
                    videoPlayer.Visible = true;
                    videoPlayer.uiMode = "none";
                    videoPlayer.settings.setMode("loop", true);
                    videoPlayer.Height = Screen.PrimaryScreen.WorkingArea.Height;
                    videoPlayer.Width = Screen.PrimaryScreen.WorkingArea.Width;
                    videoPlayer.Ctlcontrols.play();
                }
                else
                {
                    pictureBox.Image = new Bitmap(image);
                    pictureBox.Show();
                    videoPlayer.Enabled = false;
                    videoPlayer.Visible = false;
                }
            }
        }

        private Boolean IsVideoFile(string filename)
        {
            return filename.Contains("m4v");
        }
    }
}
