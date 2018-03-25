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
    public partial class CharacterForm : Form
    {
        private Character character;
        private ControlPanel cp;

        public CharacterForm(int id, ControlPanel cp)
        {
            this.cp = cp;
            InitializeComponent();
            InitializeData(id);
            InitializeFunctions();
            InitializeDataBindings();
        }

        public void InitializeData(int id)
        {
            character = Character.Find(id);
        }

        public void InitializeFunctions()
        {
            saveButton.Click += Save;
            cancelButton.Click += Cancel;
        }

        private void InitializeDataBindings()
        {
            this.nameInput.DataBindings.Add(new Binding("Text", character, "Name"));
            this.classInput.DataBindings.Add(new Binding("Text", character, "CharacterClass"));
            this.raceInput.DataBindings.Add(new Binding("Text", character, "Race"));
            this.originInput.DataBindings.Add(new Binding("Text", character, "Origin"));
            this.specializationInput.DataBindings.Add(new Binding("Text", character, "Specialization"));
            this.alignmentInput.DataBindings.Add(new Binding("Text", character, "Alignment"));

            this.levelInput.DataBindings.Add(new Binding("Value", character, "Level"));
        }

        public void Save(object sender, EventArgs e)
        {
            character.Save();
            cp.InitializeData();
            this.Close();
        }

        public void Cancel(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
