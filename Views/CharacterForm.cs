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

            this.dmNotesInput.DataBindings.Add(new Binding("Text", character, "DMNotes"));
            this.spellsInput.DataBindings.Add(new Binding("Text", character, "Spells"));
            this.inventoryInput.DataBindings.Add(new Binding("Text", character, "Inventory"));

            this.levelInput.DataBindings.Add(new Binding("Value", character, "Level"));
            this.hpInput.DataBindings.Add(new Binding("Value", character, "HitPoints"));
            this.acInput.DataBindings.Add(new Binding("Value", character, "ArmorClass"));
            this.initiativeInput.DataBindings.Add(new Binding("Value", character, "Initiative"));
            this.speedInput.DataBindings.Add(new Binding("Value", character, "Speed"));

            this.strInput.DataBindings.Add(new Binding("Value", character, "Strength"));
            this.dexInput.DataBindings.Add(new Binding("Value", character, "Dexterity"));
            this.conInput.DataBindings.Add(new Binding("Value", character, "Constitution"));
            this.intInput.DataBindings.Add(new Binding("Value", character, "Intelligence"));
            this.wisInput.DataBindings.Add(new Binding("Value", character, "Wisdom"));
            this.chaInput.DataBindings.Add(new Binding("Value", character, "Charisma"));

            this.acrobaticsCheckbox.DataBindings.Add("Checked", character, "Acrobatics");
            this.animalHandlingCheckbox.DataBindings.Add("Checked", character, "AnimalHandling");
            this.arcanaCheckbox.DataBindings.Add("Checked", character, "Arcana");
            this.athleticsCheckbox.DataBindings.Add("Checked", character, "Athletics");
            this.deceptionCheckbox.DataBindings.Add("Checked", character, "Deception");
            this.historyCheckbox.DataBindings.Add("Checked", character, "History");
            this.insightCheckbox.DataBindings.Add("Checked", character, "Insight");
            this.intimidationCheckbox.DataBindings.Add("Checked", character, "Intimidation");
            this.investigationCheckbox.DataBindings.Add("Checked", character, "Investigation");
            this.medicineCheckbox.DataBindings.Add("Checked", character, "Medicine");
            this.natureCheckbox.DataBindings.Add("Checked", character, "Nature");
            this.perceptionCheckbox.DataBindings.Add("Checked", character, "Perception");
            this.performanceCheckbox.DataBindings.Add("Checked", character, "Performance");
            this.persuasionCheckbox.DataBindings.Add("Checked", character, "Persuasion");
            this.religionCheckbox.DataBindings.Add("Checked", character, "Religion");
            this.sleightOfHandCheckbox.DataBindings.Add("Checked", character, "SleightOfHand");
            this.stealthCheckbox.DataBindings.Add("Checked", character, "Stealth");
            this.survivalCheckbox.DataBindings.Add("Checked", character, "Survival");
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
