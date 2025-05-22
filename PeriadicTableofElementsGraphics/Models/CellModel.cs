using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PeriadicTableofElementsGraphics.Models
{
    class CellModel
    {
        public Dictionary<string, AttributeModel> Attributes { get; set; }
        public SpacerModel Spacer { get; set; }
        public Color BackColor { get; set; }

        public CellModel(Dictionary<string, AttributeModel> attributes, SpacerModel spacer, Color backColor) {
            this.Attributes = attributes;
            this.Spacer = spacer;
            this.BackColor = backColor;
        }
    }
}
