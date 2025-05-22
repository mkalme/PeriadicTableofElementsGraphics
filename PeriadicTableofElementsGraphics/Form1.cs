using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace PeriadicTableofElementsGraphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Models.TableModel Table = Models.CreateTable.InitializeTable(Properties.Resources.Storage);

            //Debug.WriteLine(Table.Rows[0].Cells[0].Attributes["Atomic Number"].Font);
        }
    }
}
