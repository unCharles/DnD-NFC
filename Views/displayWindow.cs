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
                pictureBox.Image = new Bitmap(image);
                pictureBox.Show();
            }

        }
    }
}
