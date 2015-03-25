using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Drawing.Printing;
using System.IO;
using System.Xml.XPath;

//Constants for Avery Address Label 5160
/*
private const float PAPER_SIZE_WIDTH = 816f; //8.5" x 96
private const float PAPER_SIZE_HEIGHT = 1056f; //11" x 96
private const float LABEL_WIDTH = 252f; //2.625" x 96
private const float LABEL_HEIGHT = 96f; //1" x 96
private const float SIDE_MARGIN = 18.24f; //0.19" x 96
private const float TOP_MARGIN = 48f; //0.5" x 96
private const float HORIZONTAL_GAP = 12.48f; //0.13" x 96
private const float LABELS_PER_SHEET = 30f; //3 columns of 10 labels   
 * */

namespace Horran_Appartments_Database
{
    class Label
    {
        public float x; //make sure in pixels
        public float y;
        public string line1;
        public string line2;
        public string line3;

        public Label(float xPos, float yPos, string Line1, string Line2, string Line3)
        {
            x = xPos;
            y = yPos;
            line1 = Line1;
            line2 = Line2;
            line3 = Line3;
        }

        public void drawSelf(PrintPageEventArgs e, float fontHeight)
        {
            Font printFont = new System.Drawing.Font("Arial", 10); 
            e.Graphics.DrawString(line1, printFont, Brushes.Black, x, y, new StringFormat());
            e.Graphics.DrawString(line2, printFont, Brushes.Black, x, y + fontHeight, new StringFormat());
            e.Graphics.DrawString(line3, printFont, Brushes.Black, x, y + fontHeight + fontHeight, new StringFormat());
        }
    }
}
