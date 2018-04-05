using LiteDB;
using System;
using System.Collections;

namespace DnD_NFC.Models
{
    class Card
    {
        public int Id { get; set; }
        public string Hex { get; set; }
        public string Type { get; set; }
        public string Source { get; set; }

        public static Card FindOrCreate(string hex)
        {
            Card card = Find(hex);
            if (card == null)
            {
                card = Create(hex);
            }
            return card;
        }

        public static Card Create(string hex)
        {
            var db = new LiteDatabase(@Properties.Settings.Default.LiteDbPath);
            var col = db.GetCollection<Card>("cards");
            col.EnsureIndex(x => x.Hex, true);
            Card card = new Card();
            card.Hex = hex;
            col.Insert(card);
            return card;
        }

        public static Card Find(string hex)
        {
            var db = new LiteDatabase(@Properties.Settings.Default.LiteDbPath);
            var col = db.GetCollection<Card>("cards");
            return col.FindOne(Query.EQ("Hex", hex));
        }

        public static ArrayList All()
        {
            var db = new LiteDatabase(@Properties.Settings.Default.LiteDbPath);
            var col = db.GetCollection<Card>("cards");
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
            var col = db.GetCollection<Card>("cards");
            col.Update(this);
        }

        public void Delete()
        {
            var db = new LiteDatabase(@Properties.Settings.Default.LiteDbPath);
            var col = db.GetCollection<Card>("cards");
            col.Delete(Id);
        }

        override public string ToString()
        {
            string label;
            if (Type == "Character")
            {
                label = Character.Find(Int32.Parse(Source)).ToString();
            }
            else
            {
                label = Source;
            }
            return $"{Hex} {label}";
        }
    }
}
