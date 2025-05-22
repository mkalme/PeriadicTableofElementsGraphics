using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PeriadicTableofElementsGraphics.Models
{
    class AttributeModel
    {
        public string Text { get; set; }
        public Font Font { get; set; }
        public LocationModel Location { get; set; }
        public bool Visible { get; set; }

        public AttributeModel(string text, Font font, LocationModel location, bool visible){
            this.Text = text;
            this.Font = font;
            this.Location = location;
            this.Visible = visible;
        }
    }
}
