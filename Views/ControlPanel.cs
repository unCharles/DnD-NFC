using System;
using System.Windows.Forms;

namespace DnD_NFC
{
    public partial class ControlPanel : Form
    {
        public ControlPanel()
        {
            InitializeComponent();
            InitializeData();
            InitializeFunctions();
        }

        public void InitializeData()
        {
            this.characterListBox.DataSource = Character.All();
        }

        public void InitializeFunctions()
        {
            this.editCharacterButton.Click += EditCharacter;
            this.newCharacterButton.Click += NewCharacter;
            this.deleteCharacterButton.Click += DeleteCharacter;
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
    }
}
