using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriadicTableofElementsGraphics.Models
{
    class SpacerModel
    {
        public double Right { get; set; }
        public double Bottom { get; set; }

        public SpacerModel(double right, double bottom) {
            this.Right = right;
            this.Bottom = bottom;
        }
    }
}
