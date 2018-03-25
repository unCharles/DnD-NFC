using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            InitializeCharacter(id);
        }

        public void InitializeCharacter(int id)
        {
            character = Character.Find(id);
        }

        public void SetMonitor(int monitor)
        {
            this.Location = Screen.AllScreens[monitor].WorkingArea.Location;
        }
    }
}
