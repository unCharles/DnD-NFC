using LiteDB;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace DnD_NFC
{
    class Character
    {

        public int Id { get; set; }
        public string Name { get; set; }

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

        }

    }
}
