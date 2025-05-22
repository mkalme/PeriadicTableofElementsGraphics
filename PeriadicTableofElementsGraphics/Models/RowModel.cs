using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriadicTableofElementsGraphics.Models
{
    class RowModel
    {
        public CellModel[] Cells { get; set; }

        public RowModel(CellModel[] cells) {
            this.Cells = cells;
        }
    }
}
