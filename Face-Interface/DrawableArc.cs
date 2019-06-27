using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Face_Interface
{
    public class DrawableArc : Primitive, IWritable, IDrawable
    {

        protected float start;
        protected float end;


        public DrawableArc(Color aColor, bool aFilled, Rectangle aRectangle, float aStart, float aEnd) : base(aColor, aFilled, aRectangle)
        {
            start = aStart;
            end = aEnd;
        }

        public void Draw(Graphics g)
        {
            Pen pen = new Pen(color);
            g.DrawArc(pen, boundingRectangle, start, end);
        }

        public void Write(TextWriter writer)
        {
            writer.WriteLine($"Color={color}   Rectangle={boundingRectangle}    Filled={filled}    Start={start}    End={end}");
        }
    }
}

