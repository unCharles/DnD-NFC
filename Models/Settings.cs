using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_NFC.Models
{
    class Settings
    {
        public int Id { get; set; }
        public int Monitor { get; set; }
        public string DefaultImage { get; set; }
        public Boolean EnableDisplay { get; set; }
        public Boolean EnableNFC { get; set; }

        public static Settings Get()
        {
            var db = new LiteDatabase(@Properties.Settings.Default.LiteDbPath);
            var col = db.GetCollection<Settings>("settings");
            Settings settings = col.FindById(1);
            if (settings == null)
            {
                settings = new Settings();
                col.Insert(settings);
            }
            return settings;
        }

        public void Save()
        {
            var db = new LiteDatabase(@Properties.Settings.Default.LiteDbPath);
            var col = db.GetCollection<Settings>("settings");
            col.Update(this);
        }
    }
}
