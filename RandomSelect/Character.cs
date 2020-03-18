using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace RandomSelect
{
    class Character
    {
        public bool enable { get; set; } = true;
        public Image image { get; set; } = null;
        public string name { get; set; } = string.Empty;
        public string caption { get; set; } = string.Empty;

        public Character(bool enable, Image image, string name, string caption)
        {
            this.enable = enable;
            this.image = image;
            this.name = name;
            this.caption = caption;
        }
    }
}
