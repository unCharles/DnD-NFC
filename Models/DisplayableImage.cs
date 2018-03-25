using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_NFC.Models
{
    class DisplayableImage
    {
        public string ImagePath { get; set; }

        public DisplayableImage(string path)
        {
            this.ImagePath = path;
        }

        override public string ToString()
        {
            return Path.GetFileName(this.ImagePath);
        }
    }
}
