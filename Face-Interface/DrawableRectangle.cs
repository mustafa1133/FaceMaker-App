using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Face_Interface
{
    public class DrawableRectangle : Primitive, IDrawable, IWritable
    {

        public DrawableRectangle(Color aColor, bool aFilled, Rectangle aRectangle) : base(aColor, aFilled, aRectangle)
        {

        }

        public void Draw(Graphics g)
        {
            if (filled == true)
            {
                SolidBrush brush = new SolidBrush(color);
                g.FillRectangle(brush, boundingRectangle);
            }
            else
            {
                Pen pen = new Pen(color);
                g.DrawRectangle(pen, boundingRectangle);
            }

        }

        public void Write(TextWriter writer)
        {
            writer.WriteLine($"color={color}   Filled={filled}    Rectangle={boundingRectangle}");
        }
    }
}