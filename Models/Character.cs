using LiteDB;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;

namespace DnD_NFC
{
    class Character
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string CharacterClass { get; set; }
        public string Race { get; set; }
        public string Origin { get; set; }
        public string Specialization { get; set; }
        public string Alignment { get; set; }

        public int Level { get; set; }

        public int HitPoints { get; set; }
        public int ArmorClass { get; set; }
        public int Speed { get; set; }
        public int Initiative { get; set;  }

        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }

        public Boolean Acrobatics { get; set; }
        public Boolean AnimalHandling { get; set; }
        public Boolean Arcana { get; set; }
        public Boolean Athletics { get; set; }
        public Boolean Deception { get; set; }
        public Boolean History { get; set; }
        public Boolean Insight { get; set; }
        public Boolean Intimidation { get; set; }
        public Boolean Investigation { get; set; }
        public Boolean Medicine { get; set; }
        public Boolean Nature { get; set; }
        public Boolean Perception { get; set; }
        public Boolean Performance { get; set; }
        public Boolean Persuasion { get; set; }
        public Boolean Religion { get; set; }
        public Boolean SleightOfHand { get; set; }
        public Boolean Stealth { get; set; }
        public Boolean Survival { get; set; }

        public string DMNotes { get; set; }
        public string Spells { get; set; }
        public string Inventory { get; set; }

        public string CharacterImage { get; set; }

        public Character()
        {

        }

        public static Character Create()
        {
            var db = new LiteDatabase(@Properties.Settings.Default.LiteDbPath);
            var col = db.GetCollection<Character>("characters");
            Character character = new Character();
            character.Name = "Character Name";
            col.Insert(character);
            return character;
        }
   
        public static Character Find(int characterId)   
        {
            Console.WriteLine(characterId.ToString());
            var db = new LiteDatabase(@Properties.Settings.Default.LiteDbPath);
            var col = db.GetCollection<Character>("characters");
            return col.FindById(characterId);
        }

        public static ArrayList All()
        {
            var db = new LiteDatabase(@Properties.Settings.Default.LiteDbPath);
            var col = db.GetCollection<Character>("characters");
            var characters = col.FindAll();

            ArrayList list = new ArrayList();
            foreach (var character in characters)
            {
                list.Add(character);
            }
            return list;
        }
        
        public void Save()
        {
            var db = new LiteDatabase(@Properties.Settings.Default.LiteDbPath);
            var col = db.GetCollection<Character>("characters");
            Console.WriteLine(this.Name);
            col.Update(this);
        }

        public void Delete()
        {
            var db = new LiteDatabase(@Properties.Settings.Default.LiteDbPath);
            var col = db.GetCollection<Character>("characters");
            col.Delete(Id);
        }

        override public string ToString()
        {
            return $"{Name} - Level {Level} {Race} {CharacterClass}";
        }

    }
}
