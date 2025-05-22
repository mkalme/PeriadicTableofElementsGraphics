using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PeriadicTableofElementsGraphics.Models
{
    class TableModel
    {
        public RowModel[] Rows { get; set; }
        public Point Location { get; set; }

        public TableModel(RowModel[] rows, Point location) {
            this.Rows = rows;
            this.Location = location;
        }
    }
}
