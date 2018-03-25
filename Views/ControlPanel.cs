using DnD_NFC.Models;
using System;
using System.Windows.Forms;

namespace DnD_NFC
{
    public partial class ControlPanel : Form
    {
        private Settings settings;
        private DisplayWindow displayWindow;
        private int screenCount;

        public ControlPanel()
        {
            InitializeSettings();
            InitializeComponent();
            InitializeData();
            InitializeFunctions();
            InitializeDisplayWindow();
        }

        public void InitializeSettings()
        {
            settings = Settings.Get();
        }

        public void InitializeDisplayWindow()
        {
            displayWindow = new DisplayWindow();
            displayWindow.SetMonitor(settings.Monitor);
        }

        public void InitializeData()
        {
            this.characterListBox.DataSource = Character.All();
            screenCount = Screen.AllScreens.Length;
            for (int i = 0; i < screenCount; i++)
            {
                monitorSelector.Items.Add($"Monitor {i + 1}");
            }
            monitorSelector.DropDownStyle = ComboBoxStyle.DropDownList;
            monitorSelector.SelectedValueChanged += SelectedMonitorChanged;
        }

        public void InitializeFunctions()
        {
            this.editCharacterButton.Click += EditCharacter;
            this.newCharacterButton.Click += NewCharacter;
            this.deleteCharacterButton.Click += DeleteCharacter;
            this.displayCharacterButton.Click += DisplayCharacter;
            this.displayToggle.CheckedChanged += ToggleDisplay;
        }

        private void EditCharacter(object sender, EventArgs e)
        {
            Character character = (Character)characterListBox.SelectedItem;
            if (character != null)
            {
                new CharacterForm(character.Id, this).Show();
            }

        }

        private void NewCharacter(object sender, EventArgs e)
        {
            var character = Character.Create();
            new CharacterForm(character.Id, this).Show();
        }

        private void DeleteCharacter(object sender, EventArgs e)
        {
            Character character = (Character)characterListBox.SelectedItem;
            if (character == null) return;

            var confirmResult = MessageBox.Show(
                "Are you sure to delete this Character?",
                "Delete Character",
                 MessageBoxButtons.YesNo
            );

            if (confirmResult == DialogResult.Yes)
            {
                character.Delete();
                InitializeData();
            }
        }

        private void ToggleDisplay(object sender, EventArgs e)
        {
            settings.Save();
            if (displayToggle.Checked)
            {
                displayWindow.Show();
            }
            else
            {
                displayWindow.Hide();
            }
        }

        private void SelectedMonitorChanged(object sender, EventArgs e)
        {
            settings.Save();
            displayWindow.SetMonitor(monitorSelector.SelectedIndex);
        }

        private void DisplayCharacter(object sender, EventArgs e)
        {
            Character character = (Character)characterListBox.SelectedItem;
            displayWindow.DisplayCharacter(character.Id);
        }
    }
}
