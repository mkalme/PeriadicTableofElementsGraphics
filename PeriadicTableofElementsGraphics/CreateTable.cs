using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Xml;
using System.Diagnostics;

namespace PeriadicTableofElementsGraphics.Models
{
    class CreateTable
    {
        public static TableModel InitializeTable(string xmlTest) {
            XmlDocument documemt = new XmlDocument();
            documemt.LoadXml(xmlTest);

            XmlNodeList allRows = documemt.SelectNodes("/root/row");
            RowModel[] rows = new RowModel[allRows.Count];

            for (int i = 0; i < allRows.Count; i++) {
                XmlNodeList allCells = allRows[i].ChildNodes;
                CellModel[] cells = new CellModel[allCells.Count];

                for (int b = 0; b < allCells.Count; b++) {
                    CellModel cell = new CellModel(
                                                getAttributes(allCells[b]),
                                                getCellSpacer(allCells[b]),
                                                getCellColor(allCells[b])
                    );

                    cells[b] = cell;
                }

                rows[i] = new RowModel(cells);
            }

            TableModel table = new TableModel(rows, new Point(0, 0));
            return table;
        }

        private static Color getCellColor(XmlNode node) {
            Color color = Color.White;

            if (nodeHasAttribute(node, "color")) {
                color = ColorTranslator.FromHtml(node.Attributes["color"].Value);
            }

            return color;
        }
        private static Dictionary<string, AttributeModel> getAttributes(XmlNode xmlNode) {
            Dictionary<string, AttributeModel> attributes = new Dictionary<string, AttributeModel>();

            XmlNodeList texts = xmlNode.SelectNodes("attribute");
            for (int i = 0; i < texts.Count; i++) {
                if (nodeHasAttribute(texts[i], "name")) {
                    //Name
                    string name = texts[i].Attributes["name"].Value;

                    //Font
                    FontConverter fc = new FontConverter();
                    Font font = (Font)fc.ConvertFromString(texts[i].Attributes["font"].Value);

                    //Location
                    string[] doubles = texts[i].Attributes["location"].Value.Trim().Split(new string[] { ";" }, StringSplitOptions.None);
                    double x = 0;
                    double y = 0;
                    Double.TryParse(doubles[0].Replace(".", ","), out x);
                    Double.TryParse(doubles[1].Replace(".", ","), out y);

                    LocationModel location = new LocationModel(x, y);

                    //Innter Text
                    string innerText = texts[i].InnerText;

                    AttributeModel attribute = new AttributeModel(innerText, font, location, true);

                    attributes.Add(name, attribute);
                }
            }

            return attributes;
        }
        private static SpacerModel getCellSpacer(XmlNode node) {
            SpacerModel spacer = new SpacerModel(0, 0);

            if (nodeHasAttribute(node, "spacer")) {
                int spacerRight = 0;
                Int32.TryParse(node.Attributes["spacer"].Value, out spacerRight);

                spacer.Right = spacerRight;

                if (nodeHasAttribute(node.ParentNode, "spacer")) {
                    int spacerBottom = 0;
                    Int32.TryParse(node.ParentNode.Attributes["spacer"].Value, out spacerBottom);

                    spacer.Bottom = spacerBottom;
                }
            }

            return spacer;
        }



        private static bool nodeHasAttribute(XmlNode node, string attribute)
        {
            bool hasOne = false;

            for (int i = 0; i < node.Attributes.Count; i++)
            {
                if (node.Attributes[i].Name.Equals(attribute))
                {
                    hasOne = true;
                    goto after_loop;
                }
            }
            after_loop:

            return hasOne;
        }
    }
}
